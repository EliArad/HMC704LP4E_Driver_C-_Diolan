using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HardwareLib;
using static HardwareLib.SynthHMC704LP4E;

namespace HMC704ControlLib
{
    public partial class HMC703LP4EControl : UserControl
    {
        Diolan m_dln;
        SynthHMC704LP4E m_synth;
        bool m_init = false;
        List<TextBox> m_allRegs = new List<TextBox>();
        List<uint> m_regs = new List<uint>();
        int[] n_regList = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0xA, 0xB, 0xC, 0xF, 0x10, 0x11, 0x12, 0x13 };

        public HMC703LP4EControl()
        {
            InitializeComponent();
            InitRegs();
        }

        void InitRegs()
        {
            m_allRegs.Add(Reg0_result);
            m_allRegs.Add(Reg1_result);
            m_allRegs.Add(Reg2_result);
            m_allRegs.Add(Reg3_result);
            m_allRegs.Add(Reg4_result);
            m_allRegs.Add(Reg5_result);
            m_allRegs.Add(Reg6_result);
            m_allRegs.Add(Reg7_result);
            m_allRegs.Add(Reg8_result);
            m_allRegs.Add(Reg9_result);
            m_allRegs.Add(RegA_result);
            m_allRegs.Add(RegB_result);
            m_allRegs.Add(RegC_result);
            m_allRegs.Add(RegF_result);
            m_allRegs.Add(Reg10_result);
            m_allRegs.Add(Reg11_result);
            m_allRegs.Add(Reg12_result);
            m_allRegs.Add(Reg13_result);
        }
        void ReadAll()
        {
            m_init = false;
            uint data;
            int i = 0;
            foreach (byte addr in n_regList)
            {
                data = m_synth.ReadRegister(addr);
                m_allRegs[i].Text = data.ToString("X");
                i++;
            }
            m_init = true;
        }
        public void LoadControl()
        {
            m_dln = new Diolan();
            m_synth = new SynthHMC704LP4E(m_dln.DiolanDevice);
            m_synth.Initialize();

            ReadAll();
        }

        private void Reg0_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg0_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)0, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg1_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg1_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)1, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg2_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg2_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)2, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg3_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg3_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)3, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg4_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg4_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)4, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg5_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg5_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)5, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg6_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg6_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)6, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg7_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg7_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)7, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg8_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg8_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)8, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Reg9_result_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_init == false) return;
                uint data = uint.Parse(Reg9_result.Text, System.Globalization.NumberStyles.HexNumber);
                m_synth.WriteRegister((HMC704LP4E_REGS)9, data);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void ReadRegister(uint addr)
        {

            uint data;            
            data = m_synth.ReadRegister(addr);
            m_allRegs[(int)addr].Text = data.ToString("X");
        }
        private void btnReadReg0_Click(object sender, EventArgs e)
        {
            ReadRegister(0);
        }

        private void btnReadReg1_Click(object sender, EventArgs e)
        {
            ReadRegister(1);
        }
    }
}
