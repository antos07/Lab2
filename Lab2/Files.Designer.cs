﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab2 {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Files {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Files() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lab2.Files", typeof(Files).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;
        ///    xmlns:msxsl=&quot;urn:schemas-microsoft-com:xslt&quot; exclude-result-prefixes=&quot;msxsl&quot;
        ///&gt;
        ///    &lt;xsl:output method=&quot;html&quot; indent=&quot;yes&quot;/&gt;
        ///
        ///    &lt;xsl:template match=&quot;/Table&quot;&gt;
        ///		&lt;html&gt;
        ///			&lt;body&gt;
        ///				&lt;table&gt;
        ///					&lt;tr&gt;
        ///						&lt;th&gt;ПІБ&lt;/th&gt;
        ///						&lt;th&gt;Структурний підрозділ&lt;/th&gt;
        ///						&lt;th&gt;Спеціальність&lt;/th&gt;
        ///						&lt;th&gt;Група&lt;/th&gt;
        ///						&lt;th&gt;Дата вступу&lt;/th&gt;
        ///					&lt;/tr&gt;
        ///					&lt;xsl:for-each select=&quot;Ro [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string exportToHtml {
            get {
                return ResourceManager.GetString("exportToHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на &lt;xs:schema attributeFormDefault=&quot;unqualified&quot; elementFormDefault=&quot;qualified&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        ///  &lt;xs:element name=&quot;Table&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///      &lt;xs:sequence&gt;
        ///        &lt;xs:element name=&quot;Row&quot; maxOccurs=&quot;unbounded&quot; minOccurs=&quot;0&quot;&gt;
        ///          &lt;xs:complexType&gt;
        ///            &lt;xs:sequence&gt;
        ///              &lt;xs:element type=&quot;xs:string&quot; name=&quot;StudentName&quot;/&gt;
        ///              &lt;xs:element type=&quot;xs:string&quot; name=&quot;Faculty&quot;/&gt;
        ///              &lt;xs:element type=&quot;xs:string&quot; name=&quot;FieldOfStudy&quot;/&gt;
        ///            [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string tableSchema {
            get {
                return ResourceManager.GetString("tableSchema", resourceCulture);
            }
        }
    }
}