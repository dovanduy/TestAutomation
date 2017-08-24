﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace STSAndBasic.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConnexxBrandSelection recording.
    /// </summary>
    [TestModule("19371811-ec98-4765-b1a8-3f833a283576", ModuleType.Recording, 1)]
    public partial class ConnexxBrandSelection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSAndBasic.STSAndBasicRepository repository.
        /// </summary>
        public static STSAndBasic.STSAndBasicRepository repo = STSAndBasic.STSAndBasicRepository.Instance;

        static ConnexxBrandSelection instance = new ConnexxBrandSelection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConnexxBrandSelection()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConnexxBrandSelection Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Step## Launch the app
            Report.Log(ReportLevel.Info, "Section", "Step## Launch the app", new RecordItemIndex(0));
            
            StartApp();
            Delay.Milliseconds(0);
            
            // Step## Accept and Continue the initial start up text
            Report.Log(ReportLevel.Info, "Section", "Step## Accept and Continue the initial start up text", new RecordItemIndex(2));
            
            AcceptAndContinueWelcomeScreen();
            Delay.Milliseconds(0);
            
            // Step## Enter correct validation code and press done
            Report.Log(ReportLevel.Info, "Section", "Step## Enter correct validation code and press done", new RecordItemIndex(4));
            
            EnterCorrectCode();
            Delay.Milliseconds(0);
            
            DoneAuthenticationScreen();
            Delay.Milliseconds(0);
            
            TapOnContinue();
            Delay.Milliseconds(0);
            
            // Validation## Brand selection screen is opened with three options(Rexton,AudioService,A&M), Rexton selected by default. Attach a screenshot
            Report.Log(ReportLevel.Info, "Section", "Validation## Brand selection screen is opened with three options(Rexton,AudioService,A&M), Rexton selected by default. Attach a screenshot", new RecordItemIndex(8));
            
            VerifyActionBarTitle("Brand Selection");
            Delay.Milliseconds(0);
            
            ValidateContents("A&M;Audio Service;Rexton");
            Delay.Milliseconds(0);
            
            ValidateSelectedBrand("Rexton");
            Delay.Milliseconds(0);
            
            // Step## Select A&M and Press Done
            Report.Log(ReportLevel.Info, "Section", "Step## Select A&M and Press Done", new RecordItemIndex(12));
            
            SelectBrand("A&M");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            // Validation## Returns to the Custom molds screen
            Report.Log(ReportLevel.Info, "Section", "Validation## Returns to the Custom molds screen", new RecordItemIndex(15));
            
            VerifyActionBarTitle("Custom Ear Molds");
            Delay.Milliseconds(0);
            
            // Step## Turn on the Mold toggle and press Continue
            Report.Log(ReportLevel.Info, "Section", "Step## Turn on the Mold toggle and press Continue", new RecordItemIndex(17));
            
            SwitchMold(ValueConverter.ArgumentFromString<bool>("on", "True"));
            Delay.Milliseconds(0);
            
            // Validation##  The recent brand selected should be shown
            Report.Log(ReportLevel.Info, "Section", "Validation##  The recent brand selected should be shown", new RecordItemIndex(19));
            
            SelectCustoEarMoldContinue();
            Delay.Milliseconds(0);
            
            // Step## Open settings and select Brand
            Report.Log(ReportLevel.Info, "Section", "Step## Open settings and select Brand", new RecordItemIndex(21));
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            // Validation## Opens the brand list with the brand selection in step (5) indicated.
            Report.Log(ReportLevel.Info, "Section", "Validation## Opens the brand list with the brand selection in step (5) indicated.", new RecordItemIndex(23));
            
            // Step## Repeat the steps with every brand
            Report.Log(ReportLevel.Info, "Section", "Step## Repeat the steps with every brand", new RecordItemIndex(24));
            
            // Validation##  Brand selection should be saved.
            Report.Log(ReportLevel.Info, "Section", "Validation##  Brand selection should be saved.", new RecordItemIndex(25));
            
            SelectPage("Brand Selection");
            Delay.Milliseconds(0);
            
            ValidateSelectedBrand("A&M");
            Delay.Milliseconds(0);
            
            SelectBrand("Audio Service");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            SelectPage("Brand Selection");
            Delay.Milliseconds(0);
            
            ValidateSelectedBrand("Audio Service");
            Delay.Milliseconds(0);
            
            SelectBrand("Rexton");
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Done'");
            Delay.Milliseconds(0);
            
            SelectPage("Brand Selection");
            Delay.Milliseconds(0);
            
            ValidateSelectedBrand("Rexton");
            Delay.Milliseconds(0);
            
            // Step## Kill and launch the app again. Goto settings -> Brand
            Report.Log(ReportLevel.Info, "Section", "Step## Kill and launch the app again. Goto settings -> Brand", new RecordItemIndex(36));
            
            CloseApp();
            Delay.Milliseconds(0);
            
            StartApp();
            Delay.Milliseconds(0);
            
            TapOnRightButton("Tap on 'Settings'");
            Delay.Milliseconds(0);
            
            SelectPage("Brand Selection");
            Delay.Milliseconds(0);
            
            ValidateSelectedBrand("Rexton");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}