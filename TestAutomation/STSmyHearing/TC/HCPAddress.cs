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

namespace STSmyHearing.TC
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The HCPAddress recording.
    /// </summary>
    [TestModule("0fed57d8-8bc3-47d9-9bad-dc41af23ef2d", ModuleType.Recording, 1)]
    public partial class HCPAddress : ITestModule
    {
        /// <summary>
        /// Holds an instance of the STSmyHearing.STSmyHearingRepository repository.
        /// </summary>
        public static STSmyHearing.STSmyHearingRepository repo = STSmyHearing.STSmyHearingRepository.Instance;

        static HCPAddress instance = new HCPAddress();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HCPAddress()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HCPAddress Instance
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

            TapOnHome();
            Delay.Milliseconds(0);
            
            TapOn("My Hearing Care Professional");
            Delay.Milliseconds(0);
            
            ValidateContents("Am Testerweg 3;10101 Testonia");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
