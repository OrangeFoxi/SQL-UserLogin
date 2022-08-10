using MySql.Data.MySqlClient;
//für neue Projekte ;-)  Install-Package MySql.Data
namespace sqluserlogin
{
    public partial class Form1 : Form
    {
        public string name;
        public string password;
        public string securityid;
        public bool loggedin = false;
        public bool firstCheck = false;
        public bool debugMode = false;
        public bool create = false;
        public bool delete = false;
        public int randomint;
        public string createrstring;
        public int deleteint = 0;
        public int createint = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(debugMode == false)
            {
                labelDebug1.Visible = false;
                textBoxSecurityID.UseSystemPasswordChar = true;
                textBoxPassword.UseSystemPasswordChar = true;
            }
            var connectionString = "server=localhost;database=userlogin;user id=root;password=root;";
            var connectionString2 = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
            }
            this.Opacity = .70;
            labelMessage.Text = "";
            loop1();
        }

        public async void loop1()
        {
            await Task.Delay(2);
            while(true)
            {
                //name = textBoxName.Text;
                password = textBoxPassword.Text;
                securityid = textBoxSecurityID.Text;
                name = textBoxName.Text;
                await Task.Delay(10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "PLEASE FILL IN YOUR ACC. DATA -- Then press again";
            loggedin = false;
            name = textBoxName.Text;
            var connectionString2 = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
            MySqlConnection conn2 = new MySqlConnection(connectionString2);
            conn2.Open();
            if (textBoxName.Text != null && textBoxPassword.Text != null && textBoxSecurityID.Text != null)
            {
                firstCheck = true;
                MySqlCommand askcmd = new MySqlCommand("select * from logintable where uname = " + "'" + name + "'", conn2);
                MySqlDataReader reader = askcmd.ExecuteReader();
                if(reader.Read())
                {

                    
                    labelDebug1.Text = loggedin.ToString() + "," + firstCheck.ToString() + "," + name + "," + password + "," +
                    securityid + "," + reader["uname"].ToString() + "," + reader["upassword"].ToString() + "," + reader["usecurityid"].ToString();


                    if (name == reader["uname"].ToString() && password == reader["upassword"].ToString() && securityid == reader["usecurityid"].ToString())
                    {
                        labelMessage.Text = "SUCCESSFULLY LOGGED IN";
                        labelMessage.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelMessage.Text = "Your Acc. Data is Invalid";
                        labelMessage.ForeColor = Color.Red;
                    }
                }
                else
                {
                    labelMessage.Text = "Your Acc. Data is Invalid";
                    labelMessage.ForeColor = Color.Red;
                }
                reader.Close();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            createint++;
                var connectionString = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                var connectionString2 = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
                MySqlConnection conn2 = new MySqlConnection(connectionString2);
                conn2.Open();
                if (create == false)
                {
                    create = true;
                    textBoxSecurityID.Visible = false;
                    buttonLogin.Visible = false;
                    buttonDelete.Visible = false;
                    labelMessage.ForeColor = Color.Black;
                    labelMessage.Text = "PLEASE FILL IN YOUR ACC. DATA -- Then press again";
                }
                else if (create == true && textBoxName.Text != "" && textBoxPassword.Text != "")
                {
                //labelDebug1.Text = loggedin.ToString() + "," + firstCheck.ToString() + "," + name + "," + password + "," +securityid;
                createrstring = "select * from logintable where uname = '" + name + "';";//Wenn uname = null ist wird reader.Read() auch nicht ausgeführt, weil uname=reader
                MySqlCommand askcmd = new MySqlCommand(createrstring, conn);
                MySqlDataReader reader = askcmd.ExecuteReader();
                if(!reader.Read())
                {
                    if (textBoxName.Text != "" && textBoxPassword.Text != "")
                    {
                        randomint = random.Next(1000, 9999);
                        MySqlCommand createcmd = new MySqlCommand("insert into logintable values ('" + name + "', '" + password + "', " + randomint + ");", conn2);
                        MySqlDataReader readerexecuter = createcmd.ExecuteReader();
                        while (readerexecuter.Read())
                        {

                        }
                        buttonLogin.Visible = true;
                        buttonDelete.Visible = true;
                        textBoxSecurityID.Visible = true;
                        labelMessage.Text = "YOU SUCESSFULLY CREATED '" + name + "' with securityid: " + randomint.ToString();
                        labelMessage.ForeColor = Color.Green;
                        create = false;
                        textBoxName.Text = "";
                        textBoxPassword.Text = "";
                        textBoxSecurityID.Text = "";
                    }
                }
                else
                {
                    labelMessage.Text = "PLEASE TRY ANOTHER NAME";
                    labelMessage.ForeColor = Color.Red;
                    textBoxName.Text = "";
                }
                }
            if(createint == 3)
            {
                createint = 0;
                create = false;
                buttonLogin.Visible = true;
                buttonCreate.Visible = true;
                buttonDelete.Visible = true;
                textBoxSecurityID.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteint++;
            var connectionString = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            var connectionString2 = "SERVER=localhost;DATABASE=userlogin;UID=root;PASSWORD=root;";
            MySqlConnection conn2 = new MySqlConnection(connectionString2);
            conn2.Open();

            if (delete == false)
            {
                delete = true;
                buttonLogin.Visible = false;
                buttonCreate.Visible = false;
                labelMessage.ForeColor = Color.Black;
                labelMessage.Text = "PLEASE FILL IN YOUR ACC. DATA -- Then press again";
            }
            else if(delete == true)
            {
                MySqlCommand existtestcmd = new MySqlCommand("select * from logintable where uname = " + "'" + name + "' and upassword = " + "'" + password + "' and usecurityid = " + "'" + securityid + "';", conn);
                MySqlDataReader reader = existtestcmd.ExecuteReader();
                if (reader.Read())
                {
                    MySqlCommand deletecmd = new MySqlCommand("delete from logintable where uname = " + "'" + name + "' and upassword = " + "'" + password + "' and usecurityid = " + "'" + securityid + "';", conn2);
                    MySqlDataReader reader2 = deletecmd.ExecuteReader();
                    if(reader.Read())
                    {

                    }
                    labelMessage.Text = "SUCESSFULLY DELETED USER " + reader["uname"];
                    labelMessage.ForeColor = Color.Green;
                    delete = false;
                    buttonLogin.Visible = true;
                    buttonCreate.Visible = true;
                    textBoxName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxSecurityID.Text = "";
                }
                else
                {
                    labelMessage.Text = "Your Acc. Data is Invalid";
                    labelMessage.ForeColor = Color.Red;
                    textBoxName.Text = "";
                    textBoxPassword.Text = "";
                    textBoxSecurityID.Text = "";
                }
            }
            if (deleteint == 3)
            {
                deleteint = 0;
                delete = false;
                buttonLogin.Visible = true;
                buttonCreate.Visible = true;
                buttonDelete.Visible = true;
            }
        }
    }
}