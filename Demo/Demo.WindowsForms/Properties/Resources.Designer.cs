//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.WindowsForms.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Demo.WindowsForms.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die Parameter {0} can&apos;t be null ähnelt.
        /// </summary>
        internal static string IDS_ArgumentException {
            get {
                return ResourceManager.GetString("IDS_ArgumentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Value of &apos;{0}&apos; is not valid for &apos;{1}&apos;. &apos;Value&apos; should be between &apos;{2}&apos; and &apos;{3}&apos;.
        ///Parameter name: {1} ähnelt.
        /// </summary>
        internal static string IDS_InvalidBoundArgument {
            get {
                return ResourceManager.GetString("IDS_InvalidBoundArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Value of &apos;{0}&apos; is not valid for &apos;{1}&apos;. &apos;Maximum&apos; must be greater than or equal to 0.
        ///Parameter name: {1} ähnelt.
        /// </summary>
        internal static string IDS_InvalidLowBoundArgument {
            get {
                return ResourceManager.GetString("IDS_InvalidLowBoundArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Value of &apos;{0}&apos; is not valid for &apos;{1}&apos;. &apos;{1}&apos; must be greater than or equal to {2}.
        ///Parameter name: {1} ähnelt.
        /// </summary>
        internal static string IDS_InvalidOperationExceptionInteger {
            get {
                return ResourceManager.GetString("IDS_InvalidOperationExceptionInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die CREATE TABLE [Cache] (
        ///    [Ip] varchar(15) PRIMARY KEY NOT NULL,
        ///    [CountryName] text NOT NULL,
        ///    [RegionName] text NOT NULL,
        ///    [City] text NOT NULL,
        ///    [Latitude] float NOT NULL,
        ///    [Longitude] float NOT NULL,
        ///    [Time] datetime NOT NULL
        ///); ähnelt.
        /// </summary>
        internal static string IpCacheCreateDb {
            get {
                return ResourceManager.GetString("IpCacheCreateDb", resourceCulture);
            }
        }
    }
}
