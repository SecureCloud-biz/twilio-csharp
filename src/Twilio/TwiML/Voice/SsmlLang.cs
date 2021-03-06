/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Specifying Another Language for Specific Words in Say
    /// </summary>
    public class SsmlLang : TwiML 
    {
        public sealed class XmlLangEnum : StringEnum 
        {
            private XmlLangEnum(string value) : base(value) {}
            public XmlLangEnum() {}
            public static implicit operator XmlLangEnum(string value)
            {
                return new XmlLangEnum(value);
            }

            public static readonly XmlLangEnum DaDk = new XmlLangEnum("da-DK");
            public static readonly XmlLangEnum NlNl = new XmlLangEnum("nl-NL");
            public static readonly XmlLangEnum EnAu = new XmlLangEnum("en-AU");
            public static readonly XmlLangEnum EnGb = new XmlLangEnum("en-GB");
            public static readonly XmlLangEnum EnIn = new XmlLangEnum("en-IN");
            public static readonly XmlLangEnum EnUs = new XmlLangEnum("en-US");
            public static readonly XmlLangEnum EnGbWls = new XmlLangEnum("en-GB-WLS");
            public static readonly XmlLangEnum FrFr = new XmlLangEnum("fr-FR");
            public static readonly XmlLangEnum FrCa = new XmlLangEnum("fr-CA");
            public static readonly XmlLangEnum DeDe = new XmlLangEnum("de-DE");
            public static readonly XmlLangEnum IsIs = new XmlLangEnum("is-IS");
            public static readonly XmlLangEnum ItIt = new XmlLangEnum("it-IT");
            public static readonly XmlLangEnum JaJp = new XmlLangEnum("ja-JP");
            public static readonly XmlLangEnum KoKr = new XmlLangEnum("ko-KR");
            public static readonly XmlLangEnum NbNo = new XmlLangEnum("nb-NO");
            public static readonly XmlLangEnum PlPl = new XmlLangEnum("pl-PL");
            public static readonly XmlLangEnum PtBr = new XmlLangEnum("pt-BR");
            public static readonly XmlLangEnum PtPt = new XmlLangEnum("pt-PT");
            public static readonly XmlLangEnum RoRo = new XmlLangEnum("ro-RO");
            public static readonly XmlLangEnum RuRu = new XmlLangEnum("ru-RU");
            public static readonly XmlLangEnum EsEs = new XmlLangEnum("es-ES");
            public static readonly XmlLangEnum EsUs = new XmlLangEnum("es-US");
            public static readonly XmlLangEnum SvSe = new XmlLangEnum("sv-SE");
            public static readonly XmlLangEnum TrTr = new XmlLangEnum("tr-TR");
            public static readonly XmlLangEnum CyGb = new XmlLangEnum("cy-GB");
        }

        /// <summary>
        /// Words to speak
        /// </summary>
        public string Words { get; set; }
        /// <summary>
        /// Specify the language
        /// </summary>
        public SsmlLang.XmlLangEnum XmlLang { get; set; }

        /// <summary>
        /// Create a new SsmlLang
        /// </summary>
        /// <param name="words"> Words to speak, the body of the TwiML Element. </param>
        /// <param name="xml:Lang"> Specify the language </param>
        public SsmlLang(string words = null, SsmlLang.XmlLangEnum xmlLang = null) : base("lang")
        {
            this.Words = words;
            this.XmlLang = xmlLang;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Words != null ? this.Words : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.XmlLang != null)
            {
                attributes.Add(new XAttribute(XNamespace.Xml + "lang", this.XmlLang.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new SsmlLang Append(TwiML childElem)
        {
            return (SsmlLang) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new SsmlLang SetOption(string key, object value)
        {
            return (SsmlLang) base.SetOption(key, value);
        }
    }

}