using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
namespace Voice_commands
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
		private void Form1_Load(object sender, EventArgs e)
		{
			Choices voices = new Choices();
			voices.Add(new string[] { "red", "blue", "white", "green", "yellow", "close", "stop","maximize","minimize" , "give me time now" });
			GrammarBuilder grammarBuilder = new GrammarBuilder();
			grammarBuilder.Append(voices);
			Grammar grammar = new Grammar(grammarBuilder);
			sre.LoadGrammarAsync(grammar);
			sre.SetInputToDefaultAudioDevice();
			sre.SpeechRecognized += SpeechRec;
		}

		private void SpeechRec(object sender, SpeechRecognizedEventArgs e)
		{
			switch (e.Result.Text)
			{
				case "red":this.BackColor = Color.Red;
					txt.Text = "The Color Is Red Now !";
					break;
				case "blue":
					this.BackColor = Color.Blue;
					txt.Text = "The Color Is Blue Now !";
					break;
				case "white":
					this.BackColor = Color.White;
					txt.Text = "The Color Is White Now !";
					break;
				case "green":
					this.BackColor = Color.Green;
					txt.Text = "The Color Is Green Now !";
					break;
				case "yellow":
					this.BackColor = Color.Yellow;
					txt.Text = "The Color Is Yellow Now !";
					break;
				case "close":
					this.Close();
					break;
				case "stop":
					service();
					break;
				case "maximize":
					this.WindowState=FormWindowState.Maximized;
					txt.Text = "The Color Is Maximized Now !";
					break;
				case "minimize":
					this.WindowState=FormWindowState.Normal;
					txt.Text = "The Color Is Minimized Now !";
					break;
				case "give me time now":
					DateTime currentDateTime = DateTime.Now;
					txt.Text =currentDateTime.ToString();
					break;

				default:
					break;
			}
		}

		private void btntalk_Click(object sender, EventArgs e)
		{
			sre.RecognizeAsync(RecognizeMode.Multiple);
			btntalk.Enabled = false;
			btnpause.Enabled = true;
		}
		private void service()
		{
			sre.RecognizeAsyncStop();
			btntalk.Enabled = true;
			btnpause.Enabled = false;
		}
		private void btnpause_Click(object sender, EventArgs e)
		{
			service();
		}
	}
}
