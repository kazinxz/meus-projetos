/*
 * Criado por SharpDevelop.
 * Usuário: zildi
 * Data: 19/08/2025
 * Hora: 21:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jogo_da_forca
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string palavra = "";
        private string secreto = "";
        private int maxErros = 7;
        private int errosUsados = 0;
        
        
		public MainForm()
		{
			
			
			InitializeComponent();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
            if (palavra == "" && textBox2.Text != "")
        	{
            	palavra = textBox2.Text;
            	textBox2.Text = "";
            	textBox2.Visible = false;

            	secreto = "";
            	for (int i = 0; i < palavra.Length; i++)
            {
                secreto += "?";
            }
            label2.Text = secreto;
        	}
            
		}
		
		void TeclaClick(object sender, EventArgs e)
		{
			if (palavra == "")return;

        	Button btn = (Button)sender;
        	string letra = btn.Text;

        	string novoSecreto = "";
        	int acertou = 0;

        	for (int i = 0; i < palavra.Length; i++)
        	{
            	if (secreto[i] != '?')
            {
                novoSecreto += secreto[i];
            }
            	
            else if (palavra[i].ToString() == letra)
            {
                novoSecreto += letra;
                acertou = 1;
            }
            
            else
            {
                novoSecreto += "?";
            }
        }

        secreto = novoSecreto;
        label2.Text = secreto;

        	if (acertou == 0)
        	{
            	btn.BackColor = Color.Red;
            	btn.Enabled = false;
            	errosUsados = errosUsados + 1;

            	if (errosUsados <= maxErros)
            	{
                	pictureBox1.Load("erro" + errosUsados + ".png");
            	}

            	if (errosUsados >= maxErros)
            	{
                q.Enabled = false;
        		w.Enabled = false;
        		E.Enabled = false;
        		r.Enabled = false;
        		t.Enabled = false;
        		y.Enabled = false;
        		u.Enabled = false;
        		I.Enabled = false;
        		o.Enabled = false;
        		p.Enabled = false;
        		a.Enabled = false;
        		s.Enabled = false;
        		d.Enabled = false;
        		f.Enabled = false;
        		g.Enabled = false;
        		h.Enabled = false;
        		j.Enabled = false;
        		k.Enabled = false;
        		l.Enabled = false;
        		z.Enabled = false;
        		x.Enabled = false;
        		c.Enabled = false;
        		v.Enabled = false;
        		b.Enabled = false;
        		n.Enabled = false;
        		m.Enabled = false;
				button2.Enabled = false;
				MessageBox.Show("Você perdeu! Palavra: " + palavra);
            }
        }
        	
        	else
        	{
            	btn.BackColor = Color.Green;
            	btn.Enabled = false;

            	int temInterrogacao = 0;
            	for (int i = 0; i < secreto.Length; i++)
            	{
                if (secreto[i] == '?')
                {
                    temInterrogacao = 1;
                }
            }

            if (temInterrogacao == 0)
            {
            	q.Enabled = false;
        		w.Enabled = false;
        		E.Enabled = false;
        		r.Enabled = false;
        		t.Enabled = false;
        		y.Enabled = false;
        		u.Enabled = false;
        		I.Enabled = false;
        		o.Enabled = false;
        		p.Enabled = false;
        		a.Enabled = false;
        		s.Enabled = false;
        		d.Enabled = false;
        		f.Enabled = false;
        		g.Enabled = false;
        		h.Enabled = false;
        		j.Enabled = false;
        		k.Enabled = false;
        		l.Enabled = false;
        		z.Enabled = false;
        		x.Enabled = false;
        		c.Enabled = false;
        		v.Enabled = false;
        		b.Enabled = false;
        		n.Enabled = false;
        		m.Enabled = false;
				button2.Enabled = false;
                MessageBox.Show("Parabéns! Você venceu!");
            }
        		
            }		
		}
		void Button29Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	} 
}
