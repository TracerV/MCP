using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace XPUDP
{
    public partial class MCP_form : Form
    {
        private static int defaultPort;
        private static string multicastIP;

        private UdpClient ReadUDP = null;
        private UdpClient WriteUDP = null;

        private bool UDPReader = true;

        string dataref;
        int counter = 0;
        int counter1 = 0;

        string cour_1 = "";
        string ias = "";
        string hdg = "";
        string alt = "";
        bool vvi_show = false;
        bool ias_show = true;
        string vvi = "";
        string cour_2 = "";
        bool Al = true;
        int angle = 0;

        public MCP_form()
        {
            InitializeComponent();
            #region Читаем данные из файла настроек
            //Обрабатываем возможную ошибку
            try
            {
                #region Чтение данных из файла Setting.ini
                //Объявляеим переменную для чтения из файла и привязываем ее к фалу
                StreamReader fileRead = new StreamReader("Settings.ini");

                try
                {
                    //Считываем данные из файла
                    defaultPort = Convert.ToInt32(fileRead.ReadLine());
                    multicastIP = fileRead.ReadLine();
                }
                catch
                {
                    defaultPort = 49707;
                    multicastIP = "239.255.1.1";
                }
                finally
                {
                    //Закрываем файл
                    fileRead.Close();
                }
                #endregion
            }
            catch //Код если произошла ошибка
            {
                //Помещаем значения по умолчанию
                defaultPort = 49707;
                multicastIP = "239.255.1.1";
                #region Создание файла и запись данных в него
                //Создаем переменную для создания/удаления файла
                FileInfo fileInf = new FileInfo("Settings.ini");

                //Создаем переменную для записи в файл и создадем файл на жестком диске
                StreamWriter fileWrite = new StreamWriter(fileInf.Create());

                //Записываем построчно данные в файл
                fileWrite.WriteLine(defaultPort);
                fileWrite.WriteLine(multicastIP);

                //Сохраняем данные и закрываем файл
                fileWrite.Close();
                #endregion
            }
            #endregion
          //  this.Angle_pictureBox.MouseWheel += new MouseEventHandler(this.Angle_pictureBox_MouseWheel);
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_form new_form = new Settings_form();
            new_form.ShowDialog();            
        }

        #region Get/Set
        public static int Get_defaultPort ()
        {
            return defaultPort;
        }

        public static string Get_multicastIP ()
        {
            return multicastIP;
        }

        public static void Set_defaultPort(int data)
        {
            defaultPort = data;
        }

        public static void Set_multicastIP (string data)
        {
            multicastIP = data;
        }
        #endregion

        private void MCP_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Создание файла и запись данных в него
            //Создаем переменную для создания/удаления файла
            FileInfo fileInf = new FileInfo("Settings.ini");

            //Создаем переменную для записи в файл и создадем файл на жестком диске
            StreamWriter fileWrite = new StreamWriter(fileInf.Create());

            //Записываем построчно данные в файл
            fileWrite.WriteLine(defaultPort);
            fileWrite.WriteLine(multicastIP);

            //Сохраняем данные и закрываем файл
            fileWrite.Close();
            #endregion

            counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("Planes/ZIBO.txt");
            while ((dataref = file.ReadLine()) != null)
            {
                SendXPCommands(dataref, 0, counter);
                counter++;
            }
            file.Close();
            try
            {
                ReadUDP.Close();
                WriteUDP.Close();

                WriteUDP = null;
                UDPReader = false;
            }
            catch
            {
                //MessageBox.Show("Соединение не установлено");
            }

        }

        private void InitXPConnection()
        {
            if (WriteUDP == null)
            {
                UdpClient udpClient = new UdpClient();
                IPEndPoint localEP = new IPEndPoint(IPAddress.Any, defaultPort);
                udpClient.ExclusiveAddressUse = false;
                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(localEP);
                udpClient.Client.ReceiveTimeout = 1000;
                IPAddress multicastAddr = IPAddress.Parse(multicastIP);

                 NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                 NetworkInterface[] arrayNetworkInterfaces = allNetworkInterfaces;
                 for (int i = 0; i < arrayNetworkInterfaces.Length; i++)
                 {
                     NetworkInterface networkInterface = arrayNetworkInterfaces[i];
                     if (networkInterface.Supports(NetworkInterfaceComponent.IPv4) && networkInterface.OperationalStatus == OperationalStatus.Up)
                     {
                         IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
                         UnicastIPAddressInformationCollection unicastAddresses = iPProperties.UnicastAddresses;
                         IPAddress iPAddress = null;
                         foreach (UnicastIPAddressInformation current in unicastAddresses)
                         {
                             if (current.Address.AddressFamily == AddressFamily.InterNetwork)
                             {
                                 iPAddress = current.Address;
                                 break;
                             }
                         }
                         if (iPAddress != null)
                         {
                             udpClient.JoinMulticastGroup(multicastAddr, iPAddress);
                         }
                     }
                 }

                DateTime now = DateTime.Now;
                while ((DateTime.Now - now).TotalMilliseconds < (double)3000)
                {
                    try
                    {
                        IPEndPoint iPEndPoint = null;
                        byte[] receiveArray = udpClient.Receive(ref iPEndPoint);
                        if (receiveArray.Length != 0)
                        {
                            Encoding.ASCII.GetString(receiveArray);
                            using (MemoryStream memoryStream = new MemoryStream(receiveArray))
                            {
                                using (BinaryReader binaryReader = new BinaryReader(memoryStream))
                                {
                                    binaryReader.DecodeZeroArrayFromASCII(Encoding.ASCII);
                                    binaryReader.ReadChar();
                                    binaryReader.ReadChar();
                                    binaryReader.ReadInt32();
                                    int checkInt = binaryReader.ReadInt32();
                                    binaryReader.ReadUInt32();
                                    ushort port = binaryReader.ReadUInt16();
                                    binaryReader.DecodeZeroArrayFromASCII(Encoding.ASCII);
                                    if (checkInt >= 120000)
                                    {
                                        return;
                                    }
                                    IPEndPoint ipendPoint_ = new IPEndPoint(iPEndPoint.Address, (int)port);
                                    CreateUDPClientReadData(ipendPoint_);
                                    return;
                                }
                            }
                        }
                    }
                    catch (SocketException ex)
                    {
                      //  MessageBox.Show(ex.ToString());
                        MessageBox.Show("Не удалось открыть UDP соединение с симулятором");
                    }
                }
            }
            else
            {
                MessageBox.Show("Соединение уже открыто");
                return;
            }
        }

        private void CreateUDPClientReadData(IPEndPoint ipendPoint)
        {
            WriteUDP = new UdpClient
            {
                ExclusiveAddressUse = false
            };
            WriteUDP.Client.SendTimeout = 1000;
            WriteUDP.Connect(ipendPoint);

            if (WriteUDP == null)
            {
                MessageBox.Show("Не удалось открыть UDP соединение с симулятором");
                return;
            }

            ReadUDP = new UdpClient
            {
                ExclusiveAddressUse = false
            };
            ReadUDP.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            ReadUDP.Client.Bind(WriteUDP.Client.LocalEndPoint);
            ReadUDP.Client.ReceiveTimeout = 2000;

            Thread.Sleep(100);
            Thread XPRead = new Thread(new ThreadStart(ReadFromXP));
            XPRead.Start();

            System.IO.StreamReader file = new System.IO.StreamReader("Planes/ZIBO.txt");
            counter = 0;
            counter1 = 0;
            while ((dataref = file.ReadLine()) != null)
            {
                SendXPCommands(dataref, 10, counter);
                counter++;
                counter1++;
            }

            file.Close();

            /*SendXPCommands("sim/version/xplane_internal_version", 10, 1);
            SendXPCommands("sim/flightmodel/position/latitude", 10, 2);
            SendXPCommands("sim/flightmodel/position/longitude", 10, 3);
            SendXPCommands("sim/flightmodel/position/psi", 10, 4);*/

        }

        private void SendXPCommands(string command, int param, int counter)
        {
            try
            {
                byte[] array = new byte[413];
                using (MemoryStream memoryStream = new MemoryStream(array))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                    {
                        binaryWriter.EncodeCommandToASCII("RREF", Encoding.ASCII);
                        binaryWriter.Write(param);
                        binaryWriter.Write(counter); // счетчик запроса для считывания
                        binaryWriter.EncodeCommandToASCII(command, Encoding.ASCII);
                    }
                }
                WriteUDP.Send(array, array.Length);
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.ToString());
            }
        }

        private void ReadFromXP()
        {
            if (ReadUDP == null) return;

            IPEndPoint iPEndPoint = null;
            List<string> resultR = new List<string>();
            while (UDPReader)
            {
                try
                {
                    byte[] array = null;
                    try
                    {
                        array = ReadUDP.Receive(ref iPEndPoint);
                    }
                    catch (SocketException)
                    {

                    }

                    if (array != null && array.Length != 0)
                    {
                        resultR.Clear();
                        using (MemoryStream memoryStream = new MemoryStream(array))
                        {
                            using (BinaryReader binaryReader = new BinaryReader(memoryStream))
                            {
                                string header = binaryReader.DecodeArrayFromASCII(Encoding.ASCII, 5);
                                if (header != "RREFO" && header != "RREF,")
                                {
                                    continue;
                                }
                                while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
                                {
                                    int paramNum = binaryReader.ReadInt32(); // номер запроса значение параметра
                                                                             /*if (paramNum >= 1 && paramNum <= 4)
                                                                             {
                                                                                 // получаем значение параметра
                                                                                 float paramValue = binaryReader.ReadSingle();

                                                                                 resultR.Add("P: " + paramNum + "    V:    " + paramValue);
                                                                             }*/
                                    if (paramNum >= 1 && paramNum <= 32)
                                    {
                                        // получаем значение параметра
                                        double paramValue = binaryReader.ReadSingle();
                                        switch (paramNum)
                                        {
                                            case 1:
                                                {
                                                    paramValue = Math.Round(paramValue, 0);
                                                    if (paramValue < 10)
                                                    {
                                                        cour_1 = "00" + paramValue.ToString();
                                                    }
                                                    else if (paramValue < 100)
                                                    {
                                                        cour_1 = "0" + paramValue.ToString();
                                                    }
                                                    else cour_1 = paramValue.ToString();
                                                    //CicleReadPort();
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (ias_show == false) { ias = ""; }
                                                    else
                                                    {
                                                        if (paramValue < 1)
                                                        {
                                                            Al = false;
                                                            double mach = Math.Round(paramValue * 100, 0);
                                                            if (mach < 10)
                                                            { ias = ".0" + mach.ToString(); }
                                                            else { ias = "." + mach.ToString(); }
                                                        }
                                                        else
                                                        {
                                                            Al = true;
                                                            paramValue = Math.Round(paramValue, 0);
                                                            if ((paramValue >= 1) && (paramValue < 10))
                                                            {
                                                                ias = "00" + paramValue.ToString();
                                                            }
                                                            else
                                                            if ((paramValue >= 10) && (paramValue < 100))
                                                            {
                                                                ias = "0" + paramValue.ToString();
                                                            }
                                                            else
                                                                ias = paramValue.ToString();
                                                        }
                                                    }
                                                    break;
                                                }

                                            case 3:
                                                {
                                                    paramValue = Math.Round(paramValue, 0);
                                                    if (paramValue < 10)
                                                    {
                                                        hdg = "00" + paramValue.ToString();
                                                    }
                                                    else if (paramValue < 100)
                                                    {
                                                        hdg = "0" + paramValue.ToString();
                                                    }
                                                    else hdg = paramValue.ToString();
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    paramValue = Math.Round(paramValue, 0);
                                                    if (paramValue == 0)
                                                    {
                                                        alt = "00" + paramValue.ToString();
                                                    }
                                                    else
                                                        alt = paramValue.ToString();
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    if (paramValue == 0) vvi_show = false; else vvi_show = true;

                                                    break;
                                                }
                                            case 6:
                                                {
                                                    if (vvi_show == false) { vvi = "           "; }
                                                    else
                                                    {
                                                        if (paramValue < 0)
                                                        {
                                                            if ((Math.Abs(paramValue) < 100) && (Math.Abs(paramValue) != 0))
                                                            {
                                                                vvi = "-  " + Math.Abs(paramValue).ToString();
                                                            }
                                                            else
                                                            {
                                                                if ((Math.Abs(paramValue) < 1000) && (Math.Abs(paramValue) != 0))
                                                                {
                                                                    vvi = "- " + Math.Abs(paramValue).ToString();
                                                                }
                                                                else
                                                                    vvi = "-" + Math.Abs(paramValue).ToString();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if ((Math.Abs(paramValue) < 100) && (Math.Abs(paramValue) != 0))
                                                            {
                                                                vvi = "+  " + Math.Abs(paramValue).ToString();
                                                            }
                                                            else
                                                            {
                                                                if ((Math.Abs(paramValue) < 1000) && (Math.Abs(paramValue) != 0))
                                                                {
                                                                    vvi = "+ " + Math.Abs(paramValue).ToString();
                                                                }
                                                                else
                                                                    vvi = "+" + Math.Abs(paramValue).ToString();
                                                            }
                                                        }
                                                    }
                                                    break;
                                                }
                                            case 7:
                                                {
                                                    paramValue = Math.Round(paramValue, 0);
                                                    if (paramValue < 10)
                                                    {
                                                        cour_2 = "00" + paramValue.ToString();
                                                    }
                                                    else if (paramValue < 100)
                                                    {
                                                        cour_2 = "0" + paramValue.ToString();
                                                    }
                                                    else cour_2 = paramValue.ToString();
                                                    break;
                                                }
                                            case 8:
                                                {
                                                    if (paramValue == 1)
                                                    {
                                                        ias = "8" + ias;
                                                    }
                                                    break;
                                                }
                                            case 9:
                                                {
                                                    if (paramValue == 1)
                                                    {
                                                        ias = "A" + ias;
                                                    }
                                                    break;
                                                }
                                            case 10:
                                                {
                                                    if (paramValue == 0) button_V_NAV.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_V_NAV.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 11:
                                                {
                                                    if (paramValue == 0) button_L_NAV.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_L_NAV.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 12:
                                                {
                                                    if (paramValue == 0) button_CMD_A.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_CMD_A.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 13:
                                                {
                                                    if (paramValue == 0) button_CMD_B.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_CMD_B.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 14:
                                                {
                                                    if (paramValue == 0) button_VOR_LOC.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_VOR_LOC.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 15:
                                                {
                                                    if (paramValue == 0) button_CWS_A.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_CWS_A.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 16:
                                                {
                                                    if (paramValue == 0) button_CWS_B.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_CWS_B.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 17:
                                                {
                                                    if (paramValue == 0) button_N1.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_N1.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 18:
                                                {
                                                    if (paramValue == 0) button_Speed.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_Speed.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 19:
                                                {
                                                    if (paramValue == 0) button_LVL_CH.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_LVL_CH.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 20:
                                                {
                                                    if (paramValue == 0) button_HDG.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_HDG.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 21:
                                                {
                                                    if (paramValue == 0) button_APP.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_APP.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 22:
                                                {
                                                    if (paramValue == 0) button_ALT.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_ALT.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 23:
                                                {
                                                    if (paramValue == 0) button_VS.BackgroundImage = XPUDP.Properties.Resources.UnActive; else button_VS.BackgroundImage = XPUDP.Properties.Resources.Active; ;
                                                    break;
                                                }
                                            case 24:
                                                {
                                                    
                                                    break;
                                                }
                                            case 25:
                                                {
                                                    if (paramValue == 0) MA_pilot_pictureBox.BackgroundImage = XPUDP.Properties.Resources.MA_UnActive; else MA_pilot_pictureBox.BackgroundImage = XPUDP.Properties.Resources.MA_Active; ;
                                                    break;
                                                }
                                            case 26:
                                                {
                                                    if (paramValue == 0) MA_copilot_pictureBox.BackgroundImage = XPUDP.Properties.Resources.MA_UnActive; else MA_copilot_pictureBox.BackgroundImage = XPUDP.Properties.Resources.MA_Active; ;
                                                    break;
                                                }
                                            case 27:
                                                {
                                                    if (paramValue == 0) AT_pictureBox.BackgroundImage = XPUDP.Properties.Resources.AT_UnActive; else AT_pictureBox.BackgroundImage = XPUDP.Properties.Resources.AT_Active; ;
                                                    break;
                                                }
                                            case 28:
                                                {
                                                    switch (paramValue)
                                                    {
                                                        case 0:
                                                            {
                                                                Angle_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Angle_10;
                                                                angle = 0;
                                                                break;
                                                            }
                                                        case 1:
                                                            {
                                                                Angle_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Angle_15;
                                                                angle = 1;
                                                                break;
                                                            }
                                                        case 2:
                                                            {
                                                                Angle_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Angle_20;
                                                                angle = 2;
                                                                break;
                                                            }
                                                        case 3:
                                                            {
                                                                Angle_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Angle_25;
                                                                angle = 3;
                                                                break;
                                                            }
                                                        case 4:
                                                            {
                                                                Angle_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Angle_30;
                                                                angle = 4;
                                                                break;
                                                            }
                                                    }
                                                    break;
                                                }
                                            case 29:
                                                {
                                                    if (paramValue == 0) AT_sw_pictureBox.BackgroundImage = XPUDP.Properties.Resources.AT_off; else AT_sw_pictureBox.BackgroundImage = XPUDP.Properties.Resources.AT_on; ;
                                                    break;
                                                }
                                            case 30:
                                                {
                                                    if (paramValue == 0) FD_capt_pictureBox.BackgroundImage = XPUDP.Properties.Resources.FD_off; else FD_capt_pictureBox.BackgroundImage = XPUDP.Properties.Resources.FD_on; ;
                                                    break;
                                                }
                                            case 31:
                                                {
                                                    if (paramValue == 0) FD_FO_pictureBox.BackgroundImage = XPUDP.Properties.Resources.FD_off; else FD_FO_pictureBox.BackgroundImage = XPUDP.Properties.Resources.FD_on; ;
                                                    break;
                                                }
                                            case 32:
                                                {
                                                    if (paramValue == 0) Disengage_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Disengage; else Disengage_pictureBox.BackgroundImage = XPUDP.Properties.Resources.Disengage_off; ;
                                                    break;
                                                }

                                        }

                                    }
                                }
                            }
                        }
                        Course1_textBox.Invoke(new Action(() =>
                        {
                            Course1_textBox.Clear();
                            Course1_textBox.Text = cour_1;
                        }));
                        IAS_textBox.Invoke(new Action(() =>
                        {
                            IAS_textBox.Clear();
                            if (Al == true) IAS_textBox.TextAlign = HorizontalAlignment.Right; else IAS_textBox.TextAlign = HorizontalAlignment.Left;
                            IAS_textBox.Text = ias;

                        }));
                        HDG_textBox.Invoke(new Action(() =>
                        {
                            HDG_textBox.Clear();
                            HDG_textBox.Text = hdg;
                        }));
                        ALT_textBox.Invoke(new Action(() =>
                        {
                            ALT_textBox.Clear();
                            ALT_textBox.Text = alt;
                        }));
                        VS_textBox.Invoke(new Action(() =>
                        {
                            VS_textBox.Clear();
                            VS_textBox.Text = vvi;
                        }));
                        Course2_textBox.Invoke(new Action(() =>
                        {
                            Course2_textBox.Clear();
                            Course2_textBox.Text = cour_2;
                        }));
                    }
                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.ToString());
                }
            }
        }

        public bool SendXPCommands(string command)
        {
            if (WriteUDP == null)
            {
                return false;
            }
            try
            {
                bool result;
                byte[] array = new byte[509];
                using (MemoryStream memoryStream = new MemoryStream(array))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                    {
                        binaryWriter.EncodeCommandToASCII("CMND", Encoding.ASCII);
                        binaryWriter.EncodeCommandXPToASCII(command, Encoding.ASCII);
                    }
                }
                WriteUDP.Send(array, array.Length);
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        public void SendXPCommands(string command, float value)
        {
            if (WriteUDP == null)
            {
                return;
            }
            try
            {
                byte[] array = new byte[509];
                using (MemoryStream memoryStream = new MemoryStream(array))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
                    {
                        binaryWriter.EncodeCommandToASCII("DREF", Encoding.ASCII);
                        binaryWriter.Write(value);
                        binaryWriter.EncodeCommandToASCII(command, Encoding.ASCII);
                        binaryWriter.EncodeCommandXPToASCII(new string(' ', (int)(binaryWriter.BaseStream.Length - binaryWriter.BaseStream.Position)), Encoding.ASCII);
                    }
                }
                WriteUDP.Send(array, array.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            UDPReader = true;
            InitXPConnection();
        }

        private void Stop_button_Click(object sender, EventArgs e)
        {
            counter = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("Planes/ZIBO.txt");
            while ((dataref = file.ReadLine()) != null)
            {
                SendXPCommands(dataref,0,counter);
                counter++;
            }
            file.Close();
            try
            {
                ReadUDP.Close();
                WriteUDP.Close();

                WriteUDP = null;
                UDPReader = false;
            }
            catch
            {
                MessageBox.Show("Соединение не установлено");
            }
        }

        private void Reconnect_button_Click(object sender, EventArgs e)
        {
            //counter = 0;
            ////  System.IO.StreamReader file = new System.IO.StreamReader(plane);
            //while (counter <= counter1)
            //{
            //    SendXPCommands("", 10, counter);
            //    counter++;
            //}
            ////   file.Close();
            try
            {
                ReadUDP.Close();
                WriteUDP.Close();
                WriteUDP = null;
                UDPReader = false;
                System.Threading.Thread.Sleep(50);

                UDPReader = true;
                InitXPConnection();
            }
            catch
            {
                System.Threading.Thread.Sleep(50);

                UDPReader = true;
                InitXPConnection();
            }
        }

        private string MathRoud(float paramValue, int v)
        {
            throw new NotImplementedException();
        }

        private void MCP_form_Load(object sender, EventArgs e)
        {
            #region Round_Buttons
            System.Drawing.Drawing2D.GraphicsPath Button_Path_CO = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path_CO.AddEllipse(0, 0, this.button_CO.Width, this.button_CO.Height);
            Region Button_CO = new Region(Button_Path_CO);
            this.button_CO.Region = Button_CO;

            System.Drawing.Drawing2D.GraphicsPath Button_Path_SPD_INTV = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path_SPD_INTV.AddEllipse(0, 0, this.button_SPD_INTV.Width, this.button_SPD_INTV.Height);
            Region Button_SPD_INTV = new Region(Button_Path_SPD_INTV);
            this.button_SPD_INTV.Region = Button_SPD_INTV;

            System.Drawing.Drawing2D.GraphicsPath Button_Path_ALT_INTV = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path_ALT_INTV.AddEllipse(0, 0, this.button_ALT_INTV.Width, this.button_ALT_INTV.Height);
            Region Button_ALT_INTV = new Region(Button_Path_ALT_INTV);
            this.button_ALT_INTV.Region = Button_ALT_INTV;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_Angle = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_Angle.AddEllipse(0, 0, this.Angle_pictureBox.Width, this.Angle_pictureBox.Height);
            Region Picture_Angle = new Region(Picture_Path_Angle);
            this.Angle_pictureBox.Region = Picture_Angle;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_HDG = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_HDG.AddEllipse(0, 0, this.HDG_pictureBox.Width, this.HDG_pictureBox.Height);
            Region Picture_HDG = new Region(Picture_Path_HDG);
            this.HDG_pictureBox.Region = Picture_HDG;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_IAS = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_IAS.AddEllipse(0, 0, this.IAS_pictureBox.Width, this.IAS_pictureBox.Height);
            Region Picture_IAS = new Region(Picture_Path_IAS);
            this.IAS_pictureBox.Region = Picture_IAS;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_Course1 = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_Course1.AddEllipse(0, 0, this.Course1_pictureBox.Width, this.Course1_pictureBox.Height);
            Region Picture_Course1 = new Region(Picture_Path_Course1);
            this.Course1_pictureBox.Region = Picture_Course1;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_Course2 = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_Course2.AddEllipse(0, 0, this.Course2_pictureBox.Width, this.Course2_pictureBox.Height);
            Region Picture_Course2 = new Region(Picture_Path_Course2);
            this.Course2_pictureBox.Region = Picture_Course2;

            System.Drawing.Drawing2D.GraphicsPath Picture_Path_ALT = new System.Drawing.Drawing2D.GraphicsPath();
            Picture_Path_ALT.AddEllipse(0, 0, this.ALT_pictureBox.Width, this.ALT_pictureBox.Height);
            Region Picture_ALT = new Region(Picture_Path_ALT);
            this.ALT_pictureBox.Region = Picture_ALT;
            #endregion
        }

        private void button_HDG_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/hdg_sel_press");
        }

        private void button_N1_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/n1_press");
        }

        private void button_Speed_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/speed_press");
        }

        private void button_LVL_CH_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/lvl_chg_press");
        }

        private void button_APP_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/app_press");
        }

        private void button_ALT_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/alt_hld_press");
        }

        private void button_VS_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/vs_press");
        }

        private void button_VOR_LOC_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/vorloc_press");
        }

        private void button_CWS_A_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/cws_a_press");
        }

        private void button_CWS_B_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/cws_b_press");
        }

        private void button_V_NAV_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/vnav_press");
        }

        private void button_L_NAV_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/lnav_press");
        }

        private void button_CMD_A_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/cmd_a_press");
        }

        private void button_CMD_B_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/cmd_b_press");
        }

        private void button_CO_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/change_over_press");
        }

        private void button_ALT_INTV_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/alt_interv");
        }

        private void button_SPD_INTV_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/spd_interv");
        }

        private void button_ALT_INTV_Click_1(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/alt_interv");
        }

        private void Angle_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (angle == 4)
                {

                }
                else
                {
                    angle++;
                    SendXPCommands("laminar/B738/autopilot/bank_angle_up");
                }
            }
            else
            {
                if (angle == 0)
                {

                }
                else
                {
                    angle--;
                    SendXPCommands("laminar/B738/autopilot/bank_angle_dn");
                }
            } 
        }

        private void HDG_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {            
                SendXPCommands("laminar/B738/autopilot/heading_up");
            }
            else
            {
                SendXPCommands("laminar/B738/autopilot/heading_dn");
            }
        }

        private void Course1_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendXPCommands("laminar/B738/autopilot/course_pilot_up");
            }
            else
            {
                SendXPCommands("laminar/B738/autopilot/course_pilot_dn");
            }
        }

        private void Course2_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendXPCommands("laminar/B738/autopilot/course_copilot_up");
            }
            else
            {
                SendXPCommands("laminar/B738/autopilot/course_copilot_dn");
            }
        }

        private void IAS_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendXPCommands("sim/autopilot/airspeed_up");
            }
            else
            {
                SendXPCommands("sim/autopilot/airspeed_down");
            }
        }

        private void ALT_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendXPCommands("laminar/B738/autopilot/altitude_up");
            }
            else
            {
                SendXPCommands("laminar/B738/autopilot/altitude_dn");
            }
        }

        private void VS_pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                SendXPCommands("sim/autopilot/vertical_speed_down");
            }
            else
            {
                SendXPCommands("sim/autopilot/vertical_speed_up");
            }
        }

        private void AT_sw_pictureBox_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/autothrottle_arm_toggle");
        }

        private void FD_capt_pictureBox_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/flight_director_toggle");
        }

        private void FD_FO_pictureBox_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/flight_director_fo_toggle");
        }

        private void Disengage_pictureBox_Click(object sender, EventArgs e)
        {
            SendXPCommands("laminar/B738/autopilot/disconnect_toggle");
        }
    }
}
