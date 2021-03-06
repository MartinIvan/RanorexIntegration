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

namespace JustRecord
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateNewProjectGeoTech recording.
    /// </summary>
    [TestModule("6d185c2e-e2d8-4ef5-9c15-0c861750bac2", ModuleType.Recording, 1)]
    public partial class CreateNewProjectGeoTech : ITestModule
    {
        /// <summary>
        /// Holds an instance of the JustRecordRepository repository.
        /// </summary>
        public static JustRecordRepository repo = JustRecordRepository.Instance;

        static CreateNewProjectGeoTech instance = new CreateNewProjectGeoTech();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewProjectGeoTech()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewProjectGeoTech Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            UserCodeCollection1.UserZdorova();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Символ' at 43;13.", repo.GeoTech3D7ГеологияМаркшейде.СимволInfo, new RecordItemIndex(1));
            repo.GeoTech3D7ГеологияМаркшейде.Символ.Click("43;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.СоздатьCtrlPlusN' at 53;18.", repo.GeoTech.СоздатьCtrlPlusNInfo, new RecordItemIndex(2));
            repo.GeoTech.СоздатьCtrlPlusN.Click("53;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D.SbtCreateProject' at 13;13.", repo.GeoTech3D.SbtCreateProjectInfo, new RecordItemIndex(3));
            repo.GeoTech3D.SbtCreateProject.Click("13;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'g4tf3rdeswgfds'.", new RecordItemIndex(4));
            Keyboard.Press("g4tf3rdeswgfds");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D1.Применить' at 30;12.", repo.GeoTech3D1.ПрименитьInfo, new RecordItemIndex(5));
            repo.GeoTech3D1.Применить.Click("30;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.XminEdit' at 44;12.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(6));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.Click("44;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1500' with focus on 'GEOTECH3D2.TabbedNotebook1.XminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(7));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.PressKeys("1500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 33;13.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(8));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.Click("33;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2500' with focus on 'GEOTECH3D2.TabbedNotebook1.XmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(9));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.PressKeys("2500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 32;14.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(10));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.DoubleClick("32;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1300' with focus on 'GEOTECH3D2.TabbedNotebook1.YminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(11));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.PressKeys("1300");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GEOTECH3D2.TabbedNotebook1.YmaxEdit' at 37;6.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(12));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.MoveTo("37;6");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3500' with focus on 'GEOTECH3D2.TabbedNotebook1.YmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(13));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.PressKeys("3500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.Выполнить' at 48;12.", repo.GEOTECH3D2.ВыполнитьInfo, new RecordItemIndex(14));
            repo.GEOTECH3D2.Выполнить.Click("48;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement' at 8;17.", repo.GeoTech3D7ГеологияМаркшейде.SomeElementInfo, new RecordItemIndex(15));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement.Click("8;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 172;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(16));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.MoveTo("172;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 172;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(17));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.MoveTo("172;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 158;9.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(18));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.DoubleClick("158;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1234'.", new RecordItemIndex(19));
            Keyboard.Press("1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.PropOkBtn' at 35;8.", repo.GeoTech3D7ГеологияМаркшейде.PropOkBtnInfo, new RecordItemIndex(20));
            repo.GeoTech3D7ГеологияМаркшейде.PropOkBtn.Click("35;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Form65280' at 565;341.", repo.GeoTech3D7ГеологияМаркшейде.Form65280Info, new RecordItemIndex(21));
            repo.GeoTech3D7ГеологияМаркшейде.Form65280.Click("565;341");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement1' at 6;10.", repo.GeoTech3D7ГеологияМаркшейде.SomeElement1Info, new RecordItemIndex(22));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement1.Click("6;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Действия' at 13;13.", repo.GeoTech3D7ГеологияМаркшейде.ДействияInfo, new RecordItemIndex(23));
            repo.GeoTech3D7ГеологияМаркшейде.Действия.Click("13;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.ИмпортИзФайла' at 74;16.", repo.GeoTech.ИмпортИзФайлаInfo, new RecordItemIndex(24));
            repo.GeoTech.ИмпортИзФайла.Click("74;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ComboBox1136' at 112;2.", repo.Открытие.ComboBox1136Info, new RecordItemIndex(25));
            repo.Открытие.ComboBox1136.Click("112;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ФайлыAutoCAD2004DXFAsteriskDxf' at 127;6.", repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxfInfo, new RecordItemIndex(26));
            repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxf.Click("127;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.SystemItemNameDisplay' at 127;20.", repo.Открытие.SystemItemNameDisplayInfo, new RecordItemIndex(27));
            repo.Открытие.SystemItemNameDisplay.Click("127;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ButtonОткрыть' at 45;18.", repo.Открытие.ButtonОткрытьInfo, new RecordItemIndex(28));
            repo.Открытие.ButtonОткрыть.Click("45;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D3.Геодезические' at 11;4.", repo.GEOTECH3D3.ГеодезическиеInfo, new RecordItemIndex(29));
            repo.GEOTECH3D3.Геодезические.Click("11;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D3.Импорт' at 48;9.", repo.GEOTECH3D3.ИмпортInfo, new RecordItemIndex(30));
            repo.GEOTECH3D3.Импорт.Click("48;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D4.Продолжить' at 31;17.", repo.GEOTECH3D4.ПродолжитьInfo, new RecordItemIndex(31));
            repo.GEOTECH3D4.Продолжить.Click("31;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Form65280' at 704;565.", repo.GeoTech3D7ГеологияМаркшейде.Form65280Info, new RecordItemIndex(32));
            repo.GeoTech3D7ГеологияМаркшейде.Form65280.Click("704;565");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
