﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvManager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class FrmEditEnvVarSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static FrmEditEnvVarSettings defaultInstance = ((FrmEditEnvVarSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FrmEditEnvVarSettings())));
        
        public static FrmEditEnvVarSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState FrmEditWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["FrmEditWindowState"]));
            }
            set {
                this["FrmEditWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10, 10")]
        public global::System.Drawing.Point FrmEditWindowLocation {
            get {
                return ((global::System.Drawing.Point)(this["FrmEditWindowLocation"]));
            }
            set {
                this["FrmEditWindowLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("331, 319")]
        public global::System.Drawing.Size FrmSize {
            get {
                return ((global::System.Drawing.Size)(this["FrmSize"]));
            }
            set {
                this["FrmSize"] = value;
            }
        }
    }
}
