﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuditSecurityManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AuditEventFile {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AuditEventFile() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AuditSecurityManager.AuditEventFile", typeof(AuditEventFile).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} nije napravio korisnika: {1}. Razlog: {2}..
        /// </summary>
        internal static string DodajKorisnikaFailed {
            get {
                return ResourceManager.GetString("DodajKorisnikaFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} je uspesno napravio nalog: {1}..
        /// </summary>
        internal static string DodajKorisnikaSuccess {
            get {
                return ResourceManager.GetString("DodajKorisnikaSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} nije dozvoljena isplata. Razlog: {1}..
        /// </summary>
        internal static string IsplataFailed {
            get {
                return ResourceManager.GetString("IsplataFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} je uspesno isplaceno {1}.
        /// </summary>
        internal static string IsplataSuccess {
            get {
                return ResourceManager.GetString("IsplataSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} nije obrisao korisnika: {1}. Razlog: {2}..
        /// </summary>
        internal static string ObrisiKorisnikaFailed {
            get {
                return ResourceManager.GetString("ObrisiKorisnikaFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} je uspesno obrisao korisnika: {1}..
        /// </summary>
        internal static string ObrisiKorisnikaSuccess {
            get {
                return ResourceManager.GetString("ObrisiKorisnikaSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} nije dozvoljena uplata. Razlog: {1}..
        /// </summary>
        internal static string UplataFailed {
            get {
                return ResourceManager.GetString("UplataFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Korisnik {0} je uspesno uplatio {1}..
        /// </summary>
        internal static string UplataSuccess {
            get {
                return ResourceManager.GetString("UplataSuccess", resourceCulture);
            }
        }
    }
}