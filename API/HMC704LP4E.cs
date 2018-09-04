using BitField;
using Dln;
using HardwareLib.HMC704LP4ERegs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static HardwareLib.AISPI;

// http://www.analog.com/media/en/technical-documentation/data-sheets/hmc704.pdf

namespace HardwareLib
{

    namespace HMC704LP4ERegs
    {

        [global::System.AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
        sealed class BitfieldLengthAttribute : Attribute
        {
            uint length;

            public BitfieldLengthAttribute(uint length)
            {
                this.length = length;
            }

            public uint Length { get { return length; } }
        }

         
        //  RST Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG0 : IBitField
        {
            [BitFieldInfo(0, 5)]
            public uint ReadAddr { get; set; }

            [BitFieldInfo(5, 1)]
            public uint SoftRst { get; set; }
        }

        [BitFieldNumberOfBitsAttribute(32)]
        public struct CHIP_ID : IBitField
        {
            [BitFieldInfo(0, 24)]
            public uint ChipId { get; set; }

        }

        //   Reg 01h POWERDN Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG1_RST : IBitField
        {
            [BitFieldInfo(0, 1)]
            public uint chipen_pin_select { get; set; }

            [BitFieldInfo(1, 1)]
            public uint chipen_from_spi { get; set; }

            [BitFieldInfo(2, 1)]
            public uint Keep_BiasOn { get; set; }

            [BitFieldInfo(3, 1)]
            public uint Keep_PFD_on { get; set; }

            [BitFieldInfo(4, 1)]
            public uint Keep_CP_On { get; set; }

            [BitFieldInfo(5, 1)]
            public uint Keep_Ref_bufON { get; set; }

            [BitFieldInfo(6, 1)]
            public uint Keep_VCO_on { get; set; }

            [BitFieldInfo(7, 1)]
            public uint Keep_GPO_driverON { get; set; }

            [BitFieldInfo(8, 1)]
            public uint reserved { get; set; }

            [BitFieldInfo(9, 32)]
            public uint reserved2 { get; set; }


        }

        //  REF DIV Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG2_REFDIV : IBitField
        {
            [BitFieldInfo(0, 14)]
            public uint rdiv { get; set; }

            [BitFieldInfo(14, 32)]
            public uint reserved { get; set; }
        }

        //   Reg 03h Frequency Register - Integer Part
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG3_FrequencyIntegerPart : IBitField
        {
            [BitFieldInfo(0, 18)]
            public uint intg { get; set; }

            [BitFieldInfo(18, 32)]
            public uint reserved { get; set; }



        }

        //   Reg 04h Frequency Register - Fractional Part
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG4_FrequencyFractionaPart : IBitField
        {
            [BitFieldInfo(0, 24)]
            public uint frac { get; set; }

            [BitFieldInfo(24, 32)]
            public uint reserved { get; set; }

        }

        //   Reg 05h Aux SPI Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG5_AuxSPI : IBitField
        {
            [BitFieldInfo(0, 15)]
            public uint AuxData { get; set; }

            [BitFieldInfo(15, 32)]
            public uint reserved { get; set; }

        }

        //   Reg 06h SD CFG Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG6_SDCFG : IBitField
        {
            [BitFieldInfo(0, 2)]
            public uint SeedSelect { get; set; }

            [BitFieldInfo(2, 4)]
            public uint ModulatorOrder { get; set; }

            [BitFieldInfo(4, 3)]
            public uint Reserved { get; set; }

            [BitFieldInfo(7, 1)]
            public uint frac_bypass { get; set; }

            [BitFieldInfo(8, 1)]
            public uint Autoseed { get; set; }

            [BitFieldInfo(9, 1)]
            public uint clkrq_refdiv_sel { get; set; }

            [BitFieldInfo(10, 1)]
            public uint ModulatorCoreClkSelect { get; set; }

            [BitFieldInfo(11, 1)]
            public uint frac_rstb { get; set; }

            [BitFieldInfo(12, 1)]
            public uint Reserved3 { get; set; }

            [BitFieldInfo(13, 1)]
            public uint Spare { get; set; }

            [BitFieldInfo(14, 2)]
            public uint Reserved4 { get; set; }

            [BitFieldInfo(16, 2)]
            public uint Reserved5 { get; set; }

            [BitFieldInfo(18, 1)]
            public uint BISTEnable { get; set; }

            [BitFieldInfo(19, 2)]
            public uint RDIVBISTCycles { get; set; }

            [BitFieldInfo(21, 1)]
            public uint Reserved7 { get; set; }

            [BitFieldInfo(22, 1)]
            public uint Reserved8 { get; set; }

            [BitFieldInfo(23, 32)]
            public uint reserved10 { get; set; }

        }
        // Reg 07h Lock Detect Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG7_LockDetect : IBitField
        {
            [BitFieldInfo(0, 3)]
            public uint lkd_wincnt_max { get; set; }

            [BitFieldInfo(3, 1)]
            public uint EnableInternalLockDetect { get; set; }

            [BitFieldInfo(4, 2)]
            public uint Reserved { get; set; }

            [BitFieldInfo(6, 1)]
            public uint LockDetectWindowType { get; set; }

            [BitFieldInfo(7, 3)]
            public uint LDDigitalWindowDuration { get; set; }

            [BitFieldInfo(10, 2)]
            public uint LDDigitalTimerFreqControl { get; set; }

            [BitFieldInfo(12, 1)]
            public uint LDTimerTestMode { get; set; }

            [BitFieldInfo(13, 1)]
            public uint AutoRelockOneTry { get; set; }
             
            [BitFieldInfo(14, 32)]
            public uint reserved { get; set; }

        }

        //  Reg 08h Analog EN Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG8_AnalogEN : IBitField
        {
            [BitFieldInfo(0, 1)]
            public uint bias_en { get; set; }

            [BitFieldInfo(1, 1)]
            public uint cp_en { get; set; }

            [BitFieldInfo(2, 1)]
            public uint pd_en { get; set; }

            [BitFieldInfo(3, 1)]
            public uint refbuf_en { get; set; }

            [BitFieldInfo(4,1)]
            public uint vcobuf_en { get; set; }

            [BitFieldInfo(5, 1)]
            public uint GPO_LDO_SDO_pad_en { get; set; }

            [BitFieldInfo(6, 1)]
            public uint Reserved { get; set; }

            [BitFieldInfo(7, 1)]
            public uint VCO_Div_Clk_to_dig_en { get; set; }

            [BitFieldInfo(8, 1)]
            public uint Reserved2 { get; set; }

            [BitFieldInfo(9, 1)]
            public uint PrescalerClockEnable { get; set; }

            [BitFieldInfo(10, 1)]
            public uint VCOBufferAndPrescalerBiasEnable  { get; set; }

            [BitFieldInfo(11, 1)]
            public uint ChargePumpInternalOpampEnable { get; set; }

            [BitFieldInfo(12, 3)]
            public uint RFBufferEn_Bias { get; set; }

            [BitFieldInfo(15, 3)]
            public uint DivResyncEn_Bias { get; set; }

            [BitFieldInfo(18, 1)]
            public uint Reserved3 { get; set; }

            [BitFieldInfo(19, 1)]
            public uint  _8GHzDivideBy2En { get; set; }


            [BitFieldInfo(20, 1)]
            public uint Reserved4 { get; set; }

            [BitFieldInfo(21, 1)]
            public uint HiFrequencyReference { get; set; }

            [BitFieldInfo(22, 1)]
            public uint Spare1 { get; set; }

            [BitFieldInfo(23, 1)]
            public uint Spare2 { get; set; }

            [BitFieldInfo(24, 32)]
            public uint reserved { get; set; }

        }

        //Reg 09h Charge Pump Register 
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG9_ChargePump : IBitField
        {
            [BitFieldInfo(0, 7)]
            public uint CPDNGain { get; set; }

            [BitFieldInfo(7, 7)]
            public uint CPUPGain { get; set; }

            [BitFieldInfo(14, 7)]
            public uint OffsetCurrent { get; set; }

            [BitFieldInfo(21, 1)]
            public uint OffsetCurrentUP { get; set; }

            [BitFieldInfo(22, 1)]
            public uint OffsetCurrentDN { get; set; }

            [BitFieldInfo(23, 1)]
            public uint HiKChargePumpMode { get; set; }

            [BitFieldInfo(24, 32)]
            public uint reserved { get; set; }
        }

        //  Reg 0Ah AuxSPI Trigger Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG10_AuxSPITrigger : IBitField
        {
            [BitFieldInfo(0, 24)]
            public uint Reserved;

            [BitFieldInfo(24, 32)]
            public uint reserved2 { get; set; }
        }
        
        // Reg 0Bh PD Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG11_PD : IBitField
        {
             
            [BitFieldInfo(0, 3)]
            public uint pd_del_sel { get; set; }

            [BitFieldInfo(3, 1)]
            public uint ShortPDInputs { get; set; }


            [BitFieldInfo(4, 1)]
            public uint pd_Invert { get; set; }

            [BitFieldInfo(5, 1)]
            public uint pd_up_en { get; set; }

            [BitFieldInfo(6, 1)]
            public uint pd_dn_en { get; set; }

            [BitFieldInfo(7, 2)]
            public uint CSPMode { get; set; }

            [BitFieldInfo(9, 1)]
            public uint ForceCPUP { get; set; }

            [BitFieldInfo(10, 1)]
            public uint ForceCPDN { get; set; }

            [BitFieldInfo(11, 1)]
            public uint ForceCPMIdRail { get; set; }

            [BitFieldInfo(12, 3)]
            public uint PSBias { get; set; }

            [BitFieldInfo(15, 2)]
            public uint CPInternalOpAmpBias { get; set; }

            [BitFieldInfo(17, 2)]
            public uint MCounterClockGating { get; set; }

            [BitFieldInfo(19, 1)]
            public uint Spare { get; set; }

            [BitFieldInfo(20, 2)]
            public uint DividerPulseWidth { get; set; }

            [BitFieldInfo(22, 2)]
            public uint reserved2 { get; set; }

            [BitFieldInfo(24, 32)]
            public uint reserved4 { get; set; }

        }
        //https://www.codeproject.com/Articles/1095576/Bit-Field-in-Csharp-using-struct

        //  Reg 0Ch Exact Frequency Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG12_ExactFrequency : IBitField
        {
            [BitFieldInfo(0, 14)]
            public uint NumberOfChannelsPerFpd { get; set; }

            [BitFieldInfo(14, 32)]
            public uint reserved { get; set; }
        }

        

        //   Reg 0Fh GPO Register
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG15_GPO : IBitField
        {

            [BitFieldInfo(0, 5)]
            public uint gpo_select { get; set; }

            [BitFieldInfo(5, 1)]
            public uint GPOTestData { get; set; }

            [BitFieldInfo(6, 1)]
            public uint PreventAutomuxSDO { get; set; }

            [BitFieldInfo(7, 1)]
            public uint PreventDriverDisable { get; set; }

            [BitFieldInfo(8, 1)]
            public uint DisablePFET { get; set; }

            [BitFieldInfo(9, 1)]
            public uint DisableNFET { get; set; }

            [BitFieldInfo(10, 32)]
            public uint reserved { get; set; }

        }


        //   Reg 12h GPO2 Register (Read Only)
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG18_GPO2 : IBitField
        {
            [BitFieldInfo(0, 1)]
            public uint GPO { get; set; }

            [BitFieldInfo(1, 1)]
            public uint LockDetect { get; set; }

            [BitFieldInfo(2, 32)]
            public uint reserved { get; set; }

        }


        
        [BitFieldNumberOfBitsAttribute(32)]
        public struct WriteRegisterField : IBitField
        {

            [BitFieldInfo(0, 1)]
            public uint WrRdBit { get; set; }

            [BitFieldInfo(1, 6)]
            public uint Address { get; set; }

            [BitFieldInfo(7, 30)]
            public uint Data { get; set; }

            [BitFieldInfo(31, 1)]
            public uint dontCare { get; set; }

        }

        [BitFieldNumberOfBitsAttribute(32)]
        public struct ReadRegisterField : IBitField
        {
            [BitFieldInfo(0, 1)]
            public uint WrRdBit { get; set; }

            [BitFieldInfo(1, 6)]
            public uint Address { get; set; }

            [BitFieldInfo(7, 32)]
            public uint reserved { get; set; }
        }

        //   13h BIST Status (Read Only)
        [BitFieldNumberOfBitsAttribute(32)]
        public struct REG19_BISTStatus : IBitField
        {
            [BitFieldInfo(0, 16)]
            public uint BISTSignature { get; set; }

            [BitFieldInfo(16, 1)]
            public uint BISTBusy  { get; set; }

            [BitFieldInfo(17, 32)]
            public uint reserved { get; set; }

        }

        

    }
    public class SynthHMC704LP4E 
    { 
        Device m_device;
        public enum HMC704LP4E_REGS
        {
             ID = 0,
             OpenModeReadAddress = 0,
             RST = 1,
             REFDIV = 2,
             FrequencyRegisterIntegerPart = 0x3,
             FrequencyRegisterFractionalPart = 0x4,
             REG5_Seed = 0x5,
             REG6_SD_CFG = 0x6,
             REG7_LockDetect = 0x7,
             REG8_AnalogEN = 0x8,
             REG9_ChargePump = 0x9,
             REGA_AuxSPITrigger = 0xA,
             REGB_PD = 0xB,
             REGF_GPO = 0xF,
             REG12_GPO2 = 0x12,
             REG13_BISTStatus = 0x13,

        }

        public enum PowerMode
        {
            DOWN,
            UP
        }

        public enum OperationModes
        {
            Fractional = 0,
            Integer = 1,
            ExactFreqFractional = 2,
            FMMode = 3,
            PMMode = 4,
            Sweep1WayRampthenHopTriggered = 5,
            Sweep2wayRampBothDirectionsTriggered = 6,
            Sweep2wayAutoRampBothdirectionsContinuously = 7
        }

        OperationModes m_operationMode;

        

        [Serializable]
        public struct AllRegs
        {
            public CHIP_ID chipId;
            public REG1_RST reg1Rst;
            public REG2_REFDIV regRefDiv;
            public REG3_FrequencyIntegerPart regFreqInt;
            public REG4_FrequencyFractionaPart regFreqFrac;
            public REG5_AuxSPI regAuxSPI;
            public REG6_SDCFG reg6SdCfg;
            public REG7_LockDetect regLockDetect;
            public REG8_AnalogEN regAnalogEn;
            public REG9_ChargePump regChargePump;
            public REG10_AuxSPITrigger regAuxSPITrigger;
            public REG11_PD regPd;
            public REG15_GPO regGPO;
            public REG18_GPO2 regGP02;
            public REG19_BISTStatus regBitsStatus;
           

        }
    
        [Serializable]
        struct IAllRegs
        {
            public CHIP_ID chipId;
            public REG1_RST reg1Rst;
            public REG2_REFDIV regRefDiv;
            public REG3_FrequencyIntegerPart regFreqInt;
            public REG4_FrequencyFractionaPart regFreqFrac;
            public REG5_AuxSPI regAuxSPI;
            public REG6_SDCFG reg6SdCfg;
            public REG7_LockDetect regLockDetect;
            public REG8_AnalogEN regAnalogEn;
            public REG9_ChargePump regChargePump;
            public REG10_AuxSPITrigger regAuxSPITrigger;
            public REG11_PD regPd;
            public REG15_GPO regGPO;
            public REG18_GPO2 regGP02;
            public REG19_BISTStatus regBitsStatus;

        }
        IAllRegs m_allRegs;

        HMCMode m_hmc;

        public enum HMC704LP4E_DIO_REGS
        {
            SEN,
            LAST
        }

        public void ConfigurePins(int SCK_Io, int SDI_Io, int SD_LDO_Io, int SEN_Io, int CEN_Io)
        {
            m_hmc.ConfigurePins(SCK_Io, SDI_Io, SD_LDO_Io, SEN_Io, CEN_Io);
            m_hmc.Enable();
        }
        public void ConfigurePins(HMC704_CHIP_NUMBER chipNum)
        {
            m_hmc.ConfigurePins(chipNum);
            m_hmc.Enable();
        }

        public SynthHMC704LP4E(Device device)
        {
            try
            {
                m_hmc = new HMCMode(device);
                
                
            }
            catch (Exception err)
            {
                throw (new SystemException(err.Message));
            }

        }

        public SynthHMC704LP4E(Device device, HMC704_CHIP_NUMBER chipNum)
        {
            try
            {
                m_hmc = new HMCMode(device);
                ConfigurePins(chipNum);
                
            }
            catch (Exception err)
            {
                throw (new SystemException(err.Message));
            }

        }

        public void GetAllRegs(out AllRegs allRegs)
        {

            allRegs.chipId = m_allRegs.chipId;
            allRegs.reg1Rst = m_allRegs.reg1Rst;
            allRegs.regRefDiv = m_allRegs.regRefDiv;
            allRegs.regFreqInt = m_allRegs.regFreqInt;
            allRegs.regFreqFrac = m_allRegs.regFreqFrac;
            allRegs.regAuxSPI = m_allRegs.regAuxSPI;
            allRegs.reg6SdCfg = m_allRegs.reg6SdCfg;
            allRegs.regLockDetect = m_allRegs.regLockDetect;
            allRegs.regAnalogEn = m_allRegs.regAnalogEn;
            allRegs.regChargePump = m_allRegs.regChargePump;
            allRegs.regAuxSPITrigger = m_allRegs.regAuxSPITrigger;
            allRegs.regPd = m_allRegs.regPd;
            allRegs.regGPO = m_allRegs.regGPO;
            allRegs.regGP02 = m_allRegs.regGP02;
            allRegs.regBitsStatus = m_allRegs.regBitsStatus;

        }
         

        public enum DEF_FREQ
        {
            FREQ_7900,
            FREQ_8000
        }

        void SetDefault(DEF_FREQ frequency)
        {

            if (frequency == DEF_FREQ.FREQ_8000)
            {
       

                m_hmc.WriteRegister((HMC704LP4E_REGS)1, 2);
                m_hmc.WriteRegister((HMC704LP4E_REGS)2, 0x1);
                m_hmc.WriteRegister((HMC704LP4E_REGS)3, 0x50);
                m_hmc.WriteRegister((HMC704LP4E_REGS)5, 0x6095);
                m_hmc.WriteRegister((HMC704LP4E_REGS)6, 0x200B4A);
                m_hmc.WriteRegister((HMC704LP4E_REGS)7, 0xD4D);
                m_hmc.WriteRegister((HMC704LP4E_REGS)8, 0x9BEFF);
                m_hmc.WriteRegister((HMC704LP4E_REGS)9, 0xDBFFF);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xA, 0x2205);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xB, 0x78071);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xC, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xD, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xE, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xF, 0x1);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x10, 0x20);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x11, 0x8001C);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x12, 0x3);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x13, 0x1259);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x14, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x15, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x16, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x17, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x18, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x19, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1A, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1B, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1C, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1D, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1E, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1F, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x4, 0x0);

                
            }
            if (frequency == DEF_FREQ.FREQ_7900)
            {
                 

                m_hmc.WriteRegister((HMC704LP4E_REGS)1, 2);
                m_hmc.WriteRegister((HMC704LP4E_REGS)2, 0x1);
                m_hmc.WriteRegister((HMC704LP4E_REGS)3, 0x4F);
                m_hmc.WriteRegister((HMC704LP4E_REGS)5, 0x6095);
                m_hmc.WriteRegister((HMC704LP4E_REGS)6, 0x200B4A);
                m_hmc.WriteRegister((HMC704LP4E_REGS)7, 0xD4D);
                m_hmc.WriteRegister((HMC704LP4E_REGS)8, 0x9BEFF);
                m_hmc.WriteRegister((HMC704LP4E_REGS)9, 0xDBFFF);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xA, 0x2205);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xB, 0x78071);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xC, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xD, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xE, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0xF, 0x1);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x10, 0x20);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x11, 0x8001D);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x12, 0x3);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x13, 0x1259);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x14, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x15, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x16, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x17, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x18, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x19, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1A, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1B, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1C, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1D, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1E, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x1F, 0x0);
                m_hmc.WriteRegister((HMC704LP4E_REGS)0x4, 0x0);

              //  Power(PowerMode.DOWN);
                /*
                XTAL 50
                DIVIDER_MANUAL_MODE 1
                VCO_TO_SYNTH_DIV 2
                VCO_TO_OUT_DIV 1
                */
            }

            ReadAllRegisters();
        }
        public uint ReadRegister(uint address)
        {
            return m_hmc.ReadRegister((HMC704LP4E_REGS)(address));
        }
        public string Initialize()
        {
            SetDefault(DEF_FREQ.FREQ_8000);
            ReadAllRegisters();

            return "ok";
            
        }

        public bool CheckLockDetect()
        {
            uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG12_GPO2);
            m_allRegs.regGP02 = BF.CreateBitField<REG18_GPO2>(data);
            if (m_allRegs.regGP02.LockDetect == 1) return true;
            return false;

        }
        void ReadAllRegisters()
        {

            uint data;

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.ID);
            m_allRegs.chipId = BF.CreateBitField<CHIP_ID>(data);
            Console.WriteLine("m_allRegs.ID {0:X}", m_allRegs.chipId.ToUInt32());
            if (m_allRegs.chipId.ToUInt32() != 0xA7975)
            {
                throw (new SystemException("Chip ID expected to be 0xA7975"));
            } 

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.RST);
            m_allRegs.reg1Rst = BF.CreateBitField<REG1_RST>(data);
            Console.WriteLine("m_allRegs.reg1Rst {0:X}", m_allRegs.reg1Rst.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REFDIV);
            m_allRegs.regRefDiv = BF.CreateBitField<REG2_REFDIV>(data);
            Console.WriteLine("m_allRegs.regRefDiv {0:X}", m_allRegs.regRefDiv.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.FrequencyRegisterIntegerPart);
            m_allRegs.regFreqInt = BF.CreateBitField<REG3_FrequencyIntegerPart>(data);
            Console.WriteLine("m_allRegs.regFreqInt {0:X}", m_allRegs.regFreqInt.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.FrequencyRegisterFractionalPart);
            m_allRegs.regFreqFrac = BF.CreateBitField<REG4_FrequencyFractionaPart>(data);
            Console.WriteLine("m_allRegs.regFreqFrac {0:X}", m_allRegs.regFreqFrac.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG5_Seed);
            m_allRegs.regAuxSPI = BF.CreateBitField<REG5_AuxSPI>(data);
            Console.WriteLine("m_allRegs.regSeed {0:X}", m_allRegs.regAuxSPI.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG6_SD_CFG);
            m_allRegs.reg6SdCfg = BF.CreateBitField<REG6_SDCFG>(data);
            Console.WriteLine("m_allRegs.regSdCfg {0:X}", m_allRegs.reg6SdCfg.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG7_LockDetect);
            m_allRegs.regLockDetect = BF.CreateBitField<REG7_LockDetect>(data);
            Console.WriteLine("m_allRegs.regLockDetect {0:X}", m_allRegs.regLockDetect.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG8_AnalogEN);
            m_allRegs.regAnalogEn = BF.CreateBitField<REG8_AnalogEN>(data);
            Console.WriteLine("m_allRegs.regAnalogEn {0:X}", m_allRegs.regAnalogEn.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG9_ChargePump);
            m_allRegs.regChargePump = BF.CreateBitField<REG9_ChargePump>(data);
            Console.WriteLine("m_allRegs.regChargePump {0:X}", m_allRegs.regChargePump.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REGA_AuxSPITrigger);
            m_allRegs.regAuxSPITrigger = BF.CreateBitField<REG10_AuxSPITrigger>(data);
            Console.WriteLine("m_allRegs.regModulationStep {0:X}", m_allRegs.regAuxSPITrigger.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REGB_PD);
            m_allRegs.regPd = BF.CreateBitField<REG11_PD>(data);
            Console.WriteLine("m_allRegs.regPd {0:X}", m_allRegs.regPd.ToUInt64());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REGF_GPO);
            m_allRegs.regGPO = BF.CreateBitField<REG15_GPO>(data);
            Console.WriteLine("m_allRegs.regGPO {0:X}", m_allRegs.regGPO.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG12_GPO2);
            m_allRegs.regGP02 = BF.CreateBitField<REG18_GPO2>(data);
            Console.WriteLine("m_allRegs.regGP02 {0:X}", m_allRegs.regGP02.ToUInt32());

            data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG13_BISTStatus);
            m_allRegs.regBitsStatus = BF.CreateBitField<REG19_BISTStatus>(data);
            Console.WriteLine("m_allRegs.regBitsStatus {0:X}", m_allRegs.regBitsStatus.ToUInt32());
           
        }
        
        public void SetOperationMode(OperationModes mode)
        {
            if (mode == OperationModes.Integer)
            {
                uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG6_SD_CFG);
                m_allRegs.reg6SdCfg = BF.CreateBitField<REG6_SDCFG>(data);
                m_allRegs.reg6SdCfg.frac_rstb = 0;
                m_allRegs.reg6SdCfg.frac_bypass = 1;
                m_hmc.WriteRegister(HMC704LP4E_REGS.REG6_SD_CFG, m_allRegs.reg6SdCfg.ToUInt32());


                data = m_hmc.ReadRegister(HMC704LP4E_REGS.FrequencyRegisterFractionalPart);
                m_allRegs.regFreqFrac = BF.CreateBitField<REG4_FrequencyFractionaPart>(data);
                m_allRegs.regFreqFrac.frac = 1;
                m_hmc.WriteRegister(HMC704LP4E_REGS.FrequencyRegisterFractionalPart, m_allRegs.regFreqFrac.ToUInt32());

                // R = 1 - we will use the default which set to 1 already

            }
            m_operationMode = mode;
        }

        public void WriteRegister(HMC704LP4E_REGS reg, uint data)
        {
            m_hmc.WriteRegister(reg, data);
        }                

        public void Power(PowerMode mode)
        {
            uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.RST);
            m_allRegs.reg1Rst = BF.CreateBitField<REG1_RST>(data);
            //m_allRegs.reg1Rst.EnFromSPI = (uint)mode;
            m_hmc.WriteRegister(HMC704LP4E_REGS.RST, m_allRegs.reg1Rst.ToUInt32());
        }

        public uint LockDetectCount()
        {
            uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG7_LockDetect);
            m_allRegs.regLockDetect = BF.CreateBitField<REG7_LockDetect>(data);
            return m_allRegs.regLockDetect.lkd_wincnt_max;

        }
        public void LockDetectCount (int count)
        {
            uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG7_LockDetect);
            m_allRegs.regLockDetect = BF.CreateBitField<REG7_LockDetect>(data);
            //m_allRegs.reg1Rst.EnFromSPI = (uint)mode;
            m_hmc.WriteRegister(HMC704LP4E_REGS.REG7_LockDetect, m_allRegs.regLockDetect.ToUInt32());
        }

        void SetReferencePathDivisionRatio(uint data)
        {
            m_allRegs.regRefDiv.rdiv = data;
            m_hmc.WriteRegister(HMC704LP4E_REGS.REFDIV, m_allRegs.regRefDiv.ToUInt32());
        }
        void SetRFDevideBy2(bool devide)
        {
            uint data = m_hmc.ReadRegister(HMC704LP4E_REGS.REG8_AnalogEN);
            m_allRegs.regAnalogEn = BF.CreateBitField<REG8_AnalogEN>(data);
            m_allRegs.regAnalogEn._8GHzDivideBy2En = (uint)(devide == true ? 1 : 0);
            m_hmc.WriteRegister(HMC704LP4E_REGS.REG8_AnalogEN, m_allRegs.regAnalogEn.ToUInt32());
        }
         
        // Set the frequency in MHZ
        public void SetFrequency(double frequency)
        {
            frequency = frequency * 1e6;
            switch (m_operationMode)
            {

                case OperationModes.Integer:
                {

                    if (frequency >= 4e9)
                    {
                        double f = frequency;
                        double x = Math.Pow(2, 24);

                        double N = (f * x - 2 * 50e6) / (2 * 50e6 * x);
                        //Console.Write(N);

                        m_hmc.WriteRegister(HMC704LP4E_REGS.FrequencyRegisterIntegerPart, (uint)N);
                        SetRFDevideBy2(true);
                    }
                    else
                    {

                        double f = frequency;
                        double x = Math.Pow(2, 24);
                        double N = (f * x - 50e6) / (50e6 * x);
                        //Console.Write(N);
                        m_hmc.WriteRegister(HMC704LP4E_REGS.FrequencyRegisterIntegerPart, (uint)N);
                        SetRFDevideBy2(false);
                    }
                }
                break;

                case OperationModes.Fractional:
                {

                }
                break;
            }
        }
    }
}
