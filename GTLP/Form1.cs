using rnd = GTLP.randomCountry;
namespace GTLP
{
    
    public partial class Form1 : Form
    {
        static rnd rndCountry = new rnd();
        public static string newCountry = rndCountry.generateCountry();
        public static int scoreCounter = 0;
        public static int plateIndex = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(newCountry);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var countries = new Dictionary<string, string>(){
                {"Albania", "https://i.ibb.co/YQLZdH1/AL.png"},
                {"Andorra", "https://i.ibb.co/sC0q3wW/AND.png"},
                {"Armenia", "https://i.ibb.co/4SPVmbj/AM.png"},
                {"Austria", "https://i.ibb.co/Jz4nBF8/A.png"},
                {"Azerbaijan", "https://i.ibb.co/G9s7024/AZ.png"},
                {"Belarus", "https://i.ibb.co/wNXk9b0/BY.png"},
                {"Belgium", "https://i.ibb.co/xHGmByL/BE.png"},
                {"Bosnia", "https://i.ibb.co/jLBjFw1/BIH.png"},
                {"Bulgaria", "https://i.ibb.co/L5k8Fxn/BG.png"},
                {"Croatia", "https://i.ibb.co/6ygd7Xh/HR.png"},
                {"Cyprus", "https://i.ibb.co/PNb7x6T/CY.png"},
                {"Czech Republic", "https://i.ibb.co/wKTwgZ7/CZ.png"},
                {"Denmark", "https://i.ibb.co/87YJxms/DK.png"},
                {"Estonia", "https://i.ibb.co/wWBPs1x/EST.png"},
                {"Finland", "https://i.ibb.co/NSV4zHk/FIN.png"},
                {"France", "https://i.ibb.co/x2tb1ZK/FR.png"},
                {"Georgia", "https://i.ibb.co/pP9bkd0/GE.png"},
                {"Germany", "https://i.ibb.co/R7TWPvt/DE.png"},
                {"Greece", "https://i.ibb.co/bdg3w99/New-Project.png"},
                {"Hungary", "https://i.ibb.co/gtZVx52/New-Project-1.png"},
                {"Iceland", "https://i.ibb.co/6BRYWKL/New-Project-2.png"},
                {"Ireland", "https://i.ibb.co/G3nt0pB/New-Project-3.png"},
                {"Italy", "https://i.ibb.co/L9PGGgq/New-Project-4.png"},
                {"Kosovo", "https://i.ibb.co/L0Hfqzv/New-Project-5.png"},
                {"Latvia", "https://i.ibb.co/19fMB10/New-Project-6.png"},
                {"Liechtenstein", "https://i.ibb.co/WDnJ4GC/New-Project-7.png"},
                {"Lithuania", "https://i.ibb.co/mcZp38D/New-Project-8.png"},
                {"Luxembourg", "https://i.ibb.co/xmyYphj/New-Project-9.png"},
                {"Macedonia", "https://i.ibb.co/D13bsd1/New-Project-10.png"},
                {"Malta", "https://i.ibb.co/1T10sKn/New-Project-11.png"},
                {"Moldova", "https://i.ibb.co/ZS0DbPs/New-Project-12.png"},
                {"Monaco", "https://i.ibb.co/xD1pYXz/New-Project-13.png"},
                {"Montenegro", "https://i.ibb.co/hK6dfdN/New-Project-14.png"},
                {"The Netherlands", "https://i.imgur.com/8k4u3Il.png"},
                {"Norway", "https://i.imgur.com/jNEjwnY.png"},
                {"Poland", "https://i.imgur.com/Q01fUIT.png"},
                {"Portugal", "https://i.imgur.com/0blFPaS.png"},
                {"Romania", "https://i.ibb.co/b3p5Js6/RO.png"},
                {"Russia", "https://i.imgur.com/rB7rMG0.png"},
                {"San Marino", "https://i.imgur.com/Kh0NoJs.png"},
                {"Serbia", "https://i.imgur.com/DbHsBLV.png"},
                {"Slovakia", "https://i.imgur.com/qjN87OK.png"},
                {"Slovenia", "https://i.imgur.com/lVwW1qi.png"},
                {"Spain", "https://i.imgur.com/i3M8JQ0.png"},
                {"Sweden", "https://i.imgur.com/rNJkZ72.png"},
                {"Switzerland", "https://i.imgur.com/uyafert.png"},
                {"Turkey", "https://i.imgur.com/7xAmQld.png"},
                {"Ukraine", "https://i.imgur.com/jLicBsV.png"},
                {"United Kingdom", "https://i.imgur.com/aT8iEDC.png"},
                {"Vatican City", "https://i.imgur.com/sK7lRnk.png" }
            };

            if (comboBox1.Text == countries.FirstOrDefault(x => x.Value == newCountry).Key)
            {
                scoreCounter++;
                label2.Text = "Points: " + scoreCounter.ToString();
            }

            plateIndex++;
            label1.Text = "Plate #" + plateIndex.ToString();

            newCountry = rndCountry.generateCountry();
            pictureBox1.LoadAsync(newCountry);
        }
    }
}