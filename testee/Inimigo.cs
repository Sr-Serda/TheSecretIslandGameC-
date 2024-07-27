/*
 * Created by SharpDevelop.
 * User: rm20212930037
 * Date: 08/06/2022
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace testee
{
	/// <summary>
	/// Description of Inimigo.
	/// </summary>
	public class Inimigo: Personagens
	{
		public Timer relogio = new Timer();
		Random rnd = new Random();
		public SoundPlayer sominimigo = new SoundPlayer("goku black sound.wav");
		public PictureBox reinicia1 = new PictureBox();
		public PictureBox fechar = new PictureBox();
		
		public Inimigo()
		{
			Load("monstro1.gif");
			Height = 200;
			Width = 200;
			BackColor = Color.Transparent;
			Top = 0;
			Left = 1100;
			relogio.Tick += Movimentar;	
		}
		public Bullet tiro;
		public Inimigo inimigo;
		public Heroi h1;
		public Heroi h2;
		public PictureBox pb1;
		
		public void reinicia2 (object sender, EventArgs e)
		{
			Application.Restart();
		}
		public void feche (object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Movimentar (object sender, EventArgs e)
		{
			speed = 70;
			Left -= speed;
			
			
			if(Left < 0)
			{
//				sominimigo.Play();				
				
				Left = 1600;
				Top = rnd.Next(0, 400);
				
				
				
			}
			if(this.Bounds.IntersectsWith(h1.Bounds))
				{
					
					h1.Load("lordmorrendo.gif");
					h2.Load("morganamorrendo.gif");
					relogio.Enabled = false;
//					h1.Dispose();
//					h2.Dispose();
					inimigo.Dispose();
					pb1.Load("8.1.jpg");
					
					tiro.Visible = false;

					pb1.Width=1368;
					pb1.Height=768;
					
					//botão de reiniciar
					reinicia1.Parent = pb1;
					reinicia1.Height = 75;
					reinicia1.Width = 200;
					reinicia1.Left = 500;
					reinicia1.Top = 550;		
					reinicia1.BackColor = Color.Transparent;
					reinicia1.Click += reinicia2;
					
					fechar.Parent = pb1;
					fechar.Height = 65;
					fechar.Width = 200;
					fechar.Left = 700;
					fechar.Top = 550;		
					fechar.BackColor = Color.Transparent;
					fechar.Click += feche;
					

				}
			
		}
	} 
}
