/*
 * Created by SharpDevelop.
 * User: rm20212930037
 * Date: 13/04/2022
 * Time: 13:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace testee
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			fundin.Parent = this;
			fundin.Load("1.jpg");
			fundin.SizeMode = PictureBoxSizeMode.StretchImage;
			fundin.Height = 768;
			fundin.Width = 1368;
			
		}
		
		PictureBox fundin = new PictureBox();
		Heroi h1 = new Heroi();
		Heroi h2 = new Heroi();
		public Inimigo inimigo = new Inimigo();
		Cenario pb1 = new Cenario();
		PictureBox bt1 = new PictureBox();
		PictureBox bt2 = new PictureBox();
		Label msg = new Label();
		Button erro = new Button();
		public Bullet tiro = new Bullet();
		public Bullet tiro2 = new Bullet();
		Label pontos = new Label();
		public PictureBox mudar1 = new PictureBox();
		
		//		PictureBox pb = new PictureBox();
		//
		//		int cont=0;
		//		int cont2=0;

		void BtnClick(object sender, EventArgs e)
		{
			
		
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
////			pb.Left -= 25;
////			pb.Load("goku2.gif.gif");
////			if(pb.Left <= 0)
////			{
////				pb.Left = 1500;
////				
////				cont--;
////			}
////			
//////			if(cont2== 1)
//////			{
//////				pb1.Load("cei.jpg");
//////			}
////			if(cont == 2)
////			{
////				pb1.Load("cenario giku.jfif");
////			}
////			if(cont == 1)
////			{
////				pb1.Load("ceu goku.png.png");
////			}
////			
////			if(cont == 0)
////			{
////				pb1.Load("R.png");
////			}
//			
		}
		//
		void Btn3Click(object sender, EventArgs e)
		{
////			pb.Top += 25;
////			if(pb.Top >= 700)
////			{
////				pb.Top = 0;
////				
////				
////			}
////			
////		
//////			if(cont2== 1)
//////			{
//////				pb1.Load("cei.jpg");
//////			}
////////			if(cont == 1)
////////			{
////////				pb1.Load("cenario giku.jfif");
////////			}
////////			if(cont == 0)
////////			{
////////				pb1.Load("ceu goku.png.png");
////////			}
////////			
////////			if(cont == -1)
////////			{
////////				pb1.Load("R.png");
////////			}
////////			
//////			
		}
		void Btn4Click(object sender, EventArgs e)
		{
////			pb.Top -= 25;
////			if(pb.Top <=-200)
////			{
//////				pb.Top = 700;
//////				cont2=1;
//////				pb1.Load("cei.jpg");
////			
////			}
//		}
//			
//			
////			if(cont == 1)
////			{
////				pb1.Load("cenario giku.jfif");
////			}
////			if(cont == 0)
////			{
////				pb1.Load("ceu goku.png.png");
////			}
////			
////			if(cont == -1)
////			{
////				pb1.Load("R.png");
////			}
//			 
//		
//		
		}
		void goku(object sender, EventArgs e)
		{
			h1.Parent = pb1;
			h1.Load("lordparado.gif");
			h1.Height = 200;
			h1.Width = 200;
			
			h1.BackColor = Color.Transparent;
			pb1.Load("2.jpg");
			
			tiro.Load("wind.gif");
			
			inimigo.Parent = pb1;
			inimigo.relogio.Enabled = true;
			
		
			
			bt1.Enabled = false;
			bt1.Visible = false;
			
			bt2.Enabled = false;
			bt2.Visible = false;
			
			msg.Visible = false;
			msg.Enabled = false;
			
			this.KeyPreview= true;
			
		}
		public void gokuatirando(object sender, EventArgs e)
		{
			h1.Load("Linkatirando.png");
			
		}
		void buu(object sender, EventArgs e)
		{
			h2.Parent = pb1;
			h2.Load("morganaparada2.gif");
			h2.Height = 200;
			h2.Width = 200;
			
			h2.BackColor = Color.Transparent;
			
			tiro.Load("tiro.gif");
			
			pb1.Load("2.jpg");

			inimigo.Parent = pb1;
			inimigo.relogio.Enabled = true;
			
			bt1.Enabled = false;
			bt1.Visible = false;
			
			bt2.Enabled = false;
			bt2.Visible = false;
			
			msg.Visible = false;
			msg.Enabled = false;
			
			this.KeyPreview= true;
			
			
		}
		void Rest(object sender, EventArgs e)
		{
			erro.Parent = pb1;
			Application.Restart();
		}
		public int cont;
		
		void teladepersonagem(object sender, EventArgs e)
		{
			bt1.Parent = pb1;
			bt1.Load("lordparado.gif");
			bt1.Height = 200;
			bt1.Width = 200;
			bt1.Left = 490;
			bt1.Top = 300;
			bt1.BackColor = Color.Transparent;
			
			bt1.Click += goku;
				
			bt2.Parent = pb1;
			bt2.Text = "Hr2";
			bt2.Left = 890;
			bt2.Top = 310;
			bt2.Height = 300;
			bt2.Width = 300;
			bt2.Load("morganaparada2.gif");
			bt2.BackColor = Color.Transparent;
			
			bt2.Click += buu;
			
			mudar1.Visible = false;
			
			pb1.Parent = this;
			pb1.Load("escolha.png");
			
			
			
		}
			
		void Button1Click(object sender, EventArgs e)
		{
//			
//			
//			Button btn = new Button();
//			btn.Parent = this;
//			btn.BackColor = Color.Red;
//			btn.Text = "→";
//			btn.Left = 800;
//			btn.Top = 800;
//			btn.Click += BtnClick;
//			
//			
//			Button btn2 = new Button();
//			btn2.Parent = this;
//			btn2.BackColor = Color.Red;
//			btn2.Text = "←";
//			btn2.Left = 600;
//			btn2.Top = 800;
//			btn2.Click += Btn2Click;
//			
//			Button btn3 = new Button();
//			btn3.Parent = this;
//			btn3.BackColor = Color.Red;
//			btn3.Text = "↓";
//			btn3.Left = 700;
//			btn3.Top = 800;
//			btn3.Click += Btn3Click;
//			
//			Button btn4 = new Button();
//			btn4.Parent = this;
//			btn4.BackColor = Color.Red;
//			btn4.Text = "↑";
//			btn4.Left = 700;
//			btn4.Top = 750;
//			btn4.Click += Btn4Click;
//			
			
			
//			pb.Load("goku.gif.gif");
//			pb.Height = 200;
//			pb.Width = 200;
//			pb.BackColor = Color.Transparent;
//		
//			Heroi.Parent = pb1;
			
//			h1.Parent = pb1;
			
			
			
//			
//			erro.Parent = pb1;
//			erro.Text = ("restart");
//			erro.Left = 400;
//			erro.Top = 400;
//			
//			erro.Click += Rest;
			
//			bt1.Parent = pb1;
//			bt1.Load("lordparado.gif");
//			bt1.Height = 200;
//			bt1.Width = 200;
//			bt1.Left = 490;
//			bt1.Top = 300;
//			bt1.BackColor = Color.Transparent;
//			
//			bt1.Click += goku;
			
				if(!h1.Bounds.IntersectsWith(inimigo.Bounds))
				{
					erro.Enabled = true;
				
					
				}
				else
				{
					erro.Enabled = false;
				}
			
				
			
			
			
//			bt2.Parent = pb1;
//			bt2.Text = "Hr2";
//			bt2.Left = 890;
//			bt2.Top = 310;
//			bt2.Height = 300;
//			bt2.Width = 300;
//			bt2.Load("morganaparada2.gif");
//			bt2.BackColor = Color.Transparent;
//			
//			bt2.Click += buu;
			
			button1.Enabled = false;
			button1.Visible = false;
			
			
			
//			inimigo.Parent = pb1;
//			inimigo.relogio.Enabled = true;
			
		
//			pb1.Parent = this;
//			pb1.Load("escolha.png");
//			pb1.Height = 1000;
//			pb1.Width = 1600;
//			pb1.SizeMode = PictureBoxSizeMode.StretchImage;
			
		
			fundin.Visible = false;
			
			pontos.Parent = pb1;
			pontos.Height = 100;
			pontos.Width = 100;
			pontos.Top = 0;
			pontos.Left= 0;
			pontos.Text = ("SELECIONE UM PERSONAGEM");
			pontos.ForeColor = Color.Black;
			pontos.BackColor = Color.Transparent;
			pontos.Font = new Font("Arial", 25);
			pontos.Text = (tiro.cont.ToString());
			tiro.placar = pontos;
			
			inimigo.h1 = h1;
			inimigo.h2 = h2;
			
			inimigo.inimigo = inimigo;
			tiro.pb1 = pb1;
			
			tiro.h1 = h1;
			tiro.h2 = h2;
			
			inimigo.pb1 = pb1;
			
			inimigo.tiro = tiro;
			
			h1.h1=h1;
			h2.h2=h2;
			
			h1.tiro = tiro;
			
//			h1.tiro = tiro;
//			h2.tiro2 = tiro2;
			
			
			//tela de história
			fundin.Visible = false;
			mudar1.Parent = pb1;
			
			mudar1.Height = 400;
			mudar1.Width = 400;
			mudar1.Left = 1000;
			mudar1.Top = 550;		
			mudar1.BackColor = Color.Transparent;
			mudar1.Click += teladepersonagem;
			pb1.Parent = this;
			pb1.Load("2.1.jpg");
			pb1.Height = 768;
			pb1.Width = 1368;
			pb1.BackColor = Color.DarkBlue;
			pb1.SizeMode = PictureBoxSizeMode.StretchImage;
			
				
		}
			
//			public Timer relogio;
//			public Heroi heroi;
//			public Bullet  shooting;
			
		void MainFormPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
	
		}
		void True(object sender, PreviewKeyDownEventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		 public void MainFormKeyDown(object sender, KeyEventArgs e)
		{
		 	if(!h1.Bounds.IntersectsWith(inimigo.Bounds))
		 	{
		 		this.KeyPreview = false;
			if (e.KeyCode == Keys.D) {
				h1.Dir(pb1, "lordandando.gif");
				h2.Dir(pb1, "morganad.gif");		}
			if (e.KeyCode == Keys.A) {
				h1.Esq(pb1, "lordvoltando.gif");
				h2.Esq(pb1, "morganae.gif");
			}
			if (e.KeyCode == Keys.S) {
				h1.Baixo(pb1, "lordandando.gif");
				h2.Baixo(pb1, "morganad.gif");
			}
			if (e.KeyCode == Keys.W) {
				h1.Cima(pb1, "lordandando.gif");
				h2.Cima(pb1, "morganad.gif");
			}
			if(e.KeyCode == Keys.E) {
		 		
		 		h1.atirar1(pb1,"lordatacando.gif");
		 		h2.atirar2(pb1, "morganatacando.gif");
//		 		h1.tiro.Load("vento.gif");
//		 		h2.tiro.Load("ventin.gif");
		 		if(tiro.shooting == false)
		 		{
		 			
		 			tiro.inimigo = inimigo;
		 			tiro.Parent = pb1;
		 			tiro.relogio.Enabled=true;
		 			tiro.shooting = true;
		 			tiro.Left = h1.Left+200;
		 			tiro.Top = h1.Top+100;
		 			tiro.Left = h2.Left+200;
		 			tiro.Top = h2.Top+100;
				}
			}
		}
	  }
	}
}

	
