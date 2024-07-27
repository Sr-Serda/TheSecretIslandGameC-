/*
 * Created by SharpDevelop.
 * User: rm20212930037
 * Date: 10/08/2022
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace testee
{
	/// <summary>
	/// Description of Bullet.
	/// </summary>
	public class Bullet: PictureBox
	{
		public int bullet_speed;
		public Timer relogio = new Timer();
		public	bool shooting;
		public Inimigo inimigo;
		public Random rnd = new Random();
		public int cont;
		public Label placar;
		public Heroi h1;
		public Heroi h2;
		public PictureBox pb1;
		public PictureBox fundo;
		public Bullet tiro;
		public PictureBox reinicia = new PictureBox();
		public Bullet()
		{
			
			SizeMode = PictureBoxSizeMode.StretchImage;
			BackColor = Color.Transparent;
			Width = 100;
			Height = 100;
			bullet_speed=18;
			relogio.Tick += Movimentar;
		}
		
		public void reiniciar (object sender, EventArgs e)
		{
			
			
			Application.Exit();
		}
		
		public void Movimentar (object sender, EventArgs e)
		{
			bullet_speed = 18;
			Left += 25; 
			
			if(this.Bounds.IntersectsWith(inimigo.Bounds))
				{
				
				inimigo.Left = 1600;
				inimigo.Top = rnd.Next(0, 400);
//				inimigo.relogio.Enabled = false;
			 	shooting = false;
				bullet_speed = 0;
				Left = -100;
				Top = -100;
				cont++;
				placar.Text = cont.ToString();
				
				
				}
			if(shooting && Left >= 1600)
			{
				
				shooting = false;
				bullet_speed = 0;
				Left = -100;
				Top = -100;
				
			}
			
			if(cont==5)
			{		
								
				pb1.Load("3.jpg");
				inimigo.Load("monstro2.gif");
				inimigo.SizeMode = PictureBoxSizeMode.StretchImage;
				inimigo.Height=200;
				inimigo.Width=200;
				pb1.Height=1000;
				pb1.Width=1600;
			}
			if(cont==10)
			{
				pb1.Load("4.jpg");
				inimigo.Load("reiandando.gif");
				inimigo.SizeMode = PictureBoxSizeMode.StretchImage;
				inimigo.Height=300;
				inimigo.Width=300;
				pb1.Height = 1000;
				pb1.Width = 1600;
			}
			
			if(cont==15)
			{
				
				pb1.Load("9.1.jpg");
				h1.Visible=false;
				h2.Visible=false;
				h1.Enabled=false;
				h2.Enabled=false;
				inimigo.relogio.Enabled = false;
				inimigo.Enabled=false;
				inimigo.Visible=false;
				shooting = true;
				pb1.Height=700;
				pb1.Width=1400;
				
				
			}
			if(h1.Visible==false)
				{
				//botão de reiniciar
				reinicia.Parent = pb1;
				reinicia.Height = 400;
				reinicia.Width = 400;
				reinicia.Left = 570;
				reinicia.Top = 590;		
				reinicia.BackColor = Color.Transparent;
				reinicia.Click += reiniciar;
				}
		}
	}
}