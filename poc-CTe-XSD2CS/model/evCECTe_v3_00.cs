﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace CTe.v300 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/cte", IsNullable=false)]
    public partial class evCECTe : object, System.ComponentModel.INotifyPropertyChanged {
        
        private evCECTeDescEvento descEventoField;
        
        private string nProtField;
        
        private string dhEntregaField;
        
        private string nDocField;
        
        private string xNomeField;
        
        private string latitudeField;
        
        private string longitudeField;
        
        private byte[] hashEntregaField;
        
        private string dhHashEntregaField;
        
        private evCECTeInfEntrega[] infEntregaField;
        
        /// <remarks/>
        public evCECTeDescEvento descEvento {
            get {
                return this.descEventoField;
            }
            set {
                this.descEventoField = value;
                this.RaisePropertyChanged("descEvento");
            }
        }
        
        /// <remarks/>
        public string nProt {
            get {
                return this.nProtField;
            }
            set {
                this.nProtField = value;
                this.RaisePropertyChanged("nProt");
            }
        }
        
        /// <remarks/>
        public string dhEntrega {
            get {
                return this.dhEntregaField;
            }
            set {
                this.dhEntregaField = value;
                this.RaisePropertyChanged("dhEntrega");
            }
        }
        
        /// <remarks/>
        public string nDoc {
            get {
                return this.nDocField;
            }
            set {
                this.nDocField = value;
                this.RaisePropertyChanged("nDoc");
            }
        }
        
        /// <remarks/>
        public string xNome {
            get {
                return this.xNomeField;
            }
            set {
                this.xNomeField = value;
                this.RaisePropertyChanged("xNome");
            }
        }
        
        /// <remarks/>
        public string latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
                this.RaisePropertyChanged("latitude");
            }
        }
        
        /// <remarks/>
        public string longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
                this.RaisePropertyChanged("longitude");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] hashEntrega {
            get {
                return this.hashEntregaField;
            }
            set {
                this.hashEntregaField = value;
                this.RaisePropertyChanged("hashEntrega");
            }
        }
        
        /// <remarks/>
        public string dhHashEntrega {
            get {
                return this.dhHashEntregaField;
            }
            set {
                this.dhHashEntregaField = value;
                this.RaisePropertyChanged("dhHashEntrega");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infEntrega")]
        public evCECTeInfEntrega[] infEntrega {
            get {
                return this.infEntregaField;
            }
            set {
                this.infEntregaField = value;
                this.RaisePropertyChanged("infEntrega");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public enum evCECTeDescEvento {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Comprovante de Entrega do CT-e")]
        ComprovantedeEntregadoCTe,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/cte")]
    public partial class evCECTeInfEntrega : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string chNFeField;
        
        /// <remarks/>
        public string chNFe {
            get {
                return this.chNFeField;
            }
            set {
                this.chNFeField = value;
                this.RaisePropertyChanged("chNFe");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}