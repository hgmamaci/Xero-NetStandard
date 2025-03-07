/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// TaxRate
    /// </summary>
    [DataContract]
    public partial class TaxRate :  IEquatable<TaxRate>, IValidatableObject
    {
        /// <summary>
        /// See Status Codes
        /// </summary>
        /// <value>See Status Codes</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 2,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 3,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 4

        }

        /// <summary>
        /// See Status Codes
        /// </summary>
        /// <value>See Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// See ReportTaxTypes
        /// </summary>
        /// <value>See ReportTaxTypes</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum ReportTaxTypeEnum
        {
            /// <summary>
            /// Enum AVALARA for value: AVALARA
            /// </summary>
            [EnumMember(Value = "AVALARA")]
            AVALARA = 1,

            /// <summary>
            /// Enum BASEXCLUDED for value: BASEXCLUDED
            /// </summary>
            [EnumMember(Value = "BASEXCLUDED")]
            BASEXCLUDED = 2,

            /// <summary>
            /// Enum CAPITALSALESOUTPUT for value: CAPITALSALESOUTPUT
            /// </summary>
            [EnumMember(Value = "CAPITALSALESOUTPUT")]
            CAPITALSALESOUTPUT = 3,

            /// <summary>
            /// Enum CAPITALEXPENSESINPUT for value: CAPITALEXPENSESINPUT
            /// </summary>
            [EnumMember(Value = "CAPITALEXPENSESINPUT")]
            CAPITALEXPENSESINPUT = 4,

            /// <summary>
            /// Enum ECOUTPUT for value: ECOUTPUT
            /// </summary>
            [EnumMember(Value = "ECOUTPUT")]
            ECOUTPUT = 5,

            /// <summary>
            /// Enum ECOUTPUTSERVICES for value: ECOUTPUTSERVICES
            /// </summary>
            [EnumMember(Value = "ECOUTPUTSERVICES")]
            ECOUTPUTSERVICES = 6,

            /// <summary>
            /// Enum ECINPUT for value: ECINPUT
            /// </summary>
            [EnumMember(Value = "ECINPUT")]
            ECINPUT = 7,

            /// <summary>
            /// Enum ECACQUISITIONS for value: ECACQUISITIONS
            /// </summary>
            [EnumMember(Value = "ECACQUISITIONS")]
            ECACQUISITIONS = 8,

            /// <summary>
            /// Enum EXEMPTEXPENSES for value: EXEMPTEXPENSES
            /// </summary>
            [EnumMember(Value = "EXEMPTEXPENSES")]
            EXEMPTEXPENSES = 9,

            /// <summary>
            /// Enum EXEMPTINPUT for value: EXEMPTINPUT
            /// </summary>
            [EnumMember(Value = "EXEMPTINPUT")]
            EXEMPTINPUT = 10,

            /// <summary>
            /// Enum EXEMPTOUTPUT for value: EXEMPTOUTPUT
            /// </summary>
            [EnumMember(Value = "EXEMPTOUTPUT")]
            EXEMPTOUTPUT = 11,

            /// <summary>
            /// Enum GSTONIMPORTS for value: GSTONIMPORTS
            /// </summary>
            [EnumMember(Value = "GSTONIMPORTS")]
            GSTONIMPORTS = 12,

            /// <summary>
            /// Enum INPUT for value: INPUT
            /// </summary>
            [EnumMember(Value = "INPUT")]
            INPUT = 13,

            /// <summary>
            /// Enum INPUTTAXED for value: INPUTTAXED
            /// </summary>
            [EnumMember(Value = "INPUTTAXED")]
            INPUTTAXED = 14,

            /// <summary>
            /// Enum MOSSSALES for value: MOSSSALES
            /// </summary>
            [EnumMember(Value = "MOSSSALES")]
            MOSSSALES = 15,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 16,

            /// <summary>
            /// Enum NONEOUTPUT for value: NONEOUTPUT
            /// </summary>
            [EnumMember(Value = "NONEOUTPUT")]
            NONEOUTPUT = 17,

            /// <summary>
            /// Enum OUTPUT for value: OUTPUT
            /// </summary>
            [EnumMember(Value = "OUTPUT")]
            OUTPUT = 18,

            /// <summary>
            /// Enum PURCHASESINPUT for value: PURCHASESINPUT
            /// </summary>
            [EnumMember(Value = "PURCHASESINPUT")]
            PURCHASESINPUT = 19,

            /// <summary>
            /// Enum SALESOUTPUT for value: SALESOUTPUT
            /// </summary>
            [EnumMember(Value = "SALESOUTPUT")]
            SALESOUTPUT = 20,

            /// <summary>
            /// Enum EXEMPTCAPITAL for value: EXEMPTCAPITAL
            /// </summary>
            [EnumMember(Value = "EXEMPTCAPITAL")]
            EXEMPTCAPITAL = 21,

            /// <summary>
            /// Enum EXEMPTEXPORT for value: EXEMPTEXPORT
            /// </summary>
            [EnumMember(Value = "EXEMPTEXPORT")]
            EXEMPTEXPORT = 22,

            /// <summary>
            /// Enum CAPITALEXINPUT for value: CAPITALEXINPUT
            /// </summary>
            [EnumMember(Value = "CAPITALEXINPUT")]
            CAPITALEXINPUT = 23,

            /// <summary>
            /// Enum GSTONCAPIMPORTS for value: GSTONCAPIMPORTS
            /// </summary>
            [EnumMember(Value = "GSTONCAPIMPORTS")]
            GSTONCAPIMPORTS = 24,

            /// <summary>
            /// Enum GSTONCAPITALIMPORTS for value: GSTONCAPITALIMPORTS
            /// </summary>
            [EnumMember(Value = "GSTONCAPITALIMPORTS")]
            GSTONCAPITALIMPORTS = 25,

            /// <summary>
            /// Enum REVERSECHARGES for value: REVERSECHARGES
            /// </summary>
            [EnumMember(Value = "REVERSECHARGES")]
            REVERSECHARGES = 26,

            /// <summary>
            /// Enum PAYMENTS for value: PAYMENTS
            /// </summary>
            [EnumMember(Value = "PAYMENTS")]
            PAYMENTS = 27,

            /// <summary>
            /// Enum INVOICE for value: INVOICE
            /// </summary>
            [EnumMember(Value = "INVOICE")]
            INVOICE = 28,

            /// <summary>
            /// Enum CASH for value: CASH
            /// </summary>
            [EnumMember(Value = "CASH")]
            CASH = 29,

            /// <summary>
            /// Enum ACCRUAL for value: ACCRUAL
            /// </summary>
            [EnumMember(Value = "ACCRUAL")]
            ACCRUAL = 30,

            /// <summary>
            /// Enum FLATRATECASH for value: FLATRATECASH
            /// </summary>
            [EnumMember(Value = "FLATRATECASH")]
            FLATRATECASH = 31,

            /// <summary>
            /// Enum FLATRATEACCRUAL for value: FLATRATEACCRUAL
            /// </summary>
            [EnumMember(Value = "FLATRATEACCRUAL")]
            FLATRATEACCRUAL = 32,

            /// <summary>
            /// Enum ACCRUALS for value: ACCRUALS
            /// </summary>
            [EnumMember(Value = "ACCRUALS")]
            ACCRUALS = 33,

            /// <summary>
            /// Enum TXCA for value: TXCA
            /// </summary>
            [EnumMember(Value = "TXCA")]
            TXCA = 34,

            /// <summary>
            /// Enum SRCAS for value: SRCAS
            /// </summary>
            [EnumMember(Value = "SRCAS")]
            SRCAS = 35,

            /// <summary>
            /// Enum DSOUTPUT for value: DSOUTPUT
            /// </summary>
            [EnumMember(Value = "DSOUTPUT")]
            DSOUTPUT = 36,

            /// <summary>
            /// Enum BLINPUT2 for value: BLINPUT2
            /// </summary>
            [EnumMember(Value = "BLINPUT2")]
            BLINPUT2 = 37,

            /// <summary>
            /// Enum EPINPUT for value: EPINPUT
            /// </summary>
            [EnumMember(Value = "EPINPUT")]
            EPINPUT = 38,

            /// <summary>
            /// Enum IMINPUT2 for value: IMINPUT2
            /// </summary>
            [EnumMember(Value = "IMINPUT2")]
            IMINPUT2 = 39,

            /// <summary>
            /// Enum MEINPUT for value: MEINPUT
            /// </summary>
            [EnumMember(Value = "MEINPUT")]
            MEINPUT = 40,

            /// <summary>
            /// Enum IGDSINPUT2 for value: IGDSINPUT2
            /// </summary>
            [EnumMember(Value = "IGDSINPUT2")]
            IGDSINPUT2 = 41,

            /// <summary>
            /// Enum ESN33OUTPUT for value: ESN33OUTPUT
            /// </summary>
            [EnumMember(Value = "ESN33OUTPUT")]
            ESN33OUTPUT = 42,

            /// <summary>
            /// Enum OPINPUT for value: OPINPUT
            /// </summary>
            [EnumMember(Value = "OPINPUT")]
            OPINPUT = 43,

            /// <summary>
            /// Enum OSOUTPUT for value: OSOUTPUT
            /// </summary>
            [EnumMember(Value = "OSOUTPUT")]
            OSOUTPUT = 44,

            /// <summary>
            /// Enum TXN33INPUT for value: TXN33INPUT
            /// </summary>
            [EnumMember(Value = "TXN33INPUT")]
            TXN33INPUT = 45,

            /// <summary>
            /// Enum TXESSINPUT for value: TXESSINPUT
            /// </summary>
            [EnumMember(Value = "TXESSINPUT")]
            TXESSINPUT = 46,

            /// <summary>
            /// Enum TXREINPUT for value: TXREINPUT
            /// </summary>
            [EnumMember(Value = "TXREINPUT")]
            TXREINPUT = 47,

            /// <summary>
            /// Enum TXPETINPUT for value: TXPETINPUT
            /// </summary>
            [EnumMember(Value = "TXPETINPUT")]
            TXPETINPUT = 48,

            /// <summary>
            /// Enum NRINPUT for value: NRINPUT
            /// </summary>
            [EnumMember(Value = "NRINPUT")]
            NRINPUT = 49,

            /// <summary>
            /// Enum ES33OUTPUT for value: ES33OUTPUT
            /// </summary>
            [EnumMember(Value = "ES33OUTPUT")]
            ES33OUTPUT = 50,

            /// <summary>
            /// Enum ZERORATEDINPUT for value: ZERORATEDINPUT
            /// </summary>
            [EnumMember(Value = "ZERORATEDINPUT")]
            ZERORATEDINPUT = 51,

            /// <summary>
            /// Enum ZERORATEDOUTPUT for value: ZERORATEDOUTPUT
            /// </summary>
            [EnumMember(Value = "ZERORATEDOUTPUT")]
            ZERORATEDOUTPUT = 52,

            /// <summary>
            /// Enum DRCHARGESUPPLY for value: DRCHARGESUPPLY
            /// </summary>
            [EnumMember(Value = "DRCHARGESUPPLY")]
            DRCHARGESUPPLY = 53,

            /// <summary>
            /// Enum DRCHARGE for value: DRCHARGE
            /// </summary>
            [EnumMember(Value = "DRCHARGE")]
            DRCHARGE = 54,

            /// <summary>
            /// Enum CAPINPUT for value: CAPINPUT
            /// </summary>
            [EnumMember(Value = "CAPINPUT")]
            CAPINPUT = 55,

            /// <summary>
            /// Enum CAPIMPORTS for value: CAPIMPORTS
            /// </summary>
            [EnumMember(Value = "CAPIMPORTS")]
            CAPIMPORTS = 56,

            /// <summary>
            /// Enum IMINPUT for value: IMINPUT
            /// </summary>
            [EnumMember(Value = "IMINPUT")]
            IMINPUT = 57,

            /// <summary>
            /// Enum INPUT2 for value: INPUT2
            /// </summary>
            [EnumMember(Value = "INPUT2")]
            INPUT2 = 58,

            /// <summary>
            /// Enum CIUINPUT for value: CIUINPUT
            /// </summary>
            [EnumMember(Value = "CIUINPUT")]
            CIUINPUT = 59,

            /// <summary>
            /// Enum SRINPUT for value: SRINPUT
            /// </summary>
            [EnumMember(Value = "SRINPUT")]
            SRINPUT = 60,

            /// <summary>
            /// Enum OUTPUT2 for value: OUTPUT2
            /// </summary>
            [EnumMember(Value = "OUTPUT2")]
            OUTPUT2 = 61,

            /// <summary>
            /// Enum SROUTPUT for value: SROUTPUT
            /// </summary>
            [EnumMember(Value = "SROUTPUT")]
            SROUTPUT = 62,

            /// <summary>
            /// Enum CAPOUTPUT for value: CAPOUTPUT
            /// </summary>
            [EnumMember(Value = "CAPOUTPUT")]
            CAPOUTPUT = 63,

            /// <summary>
            /// Enum SROUTPUT2 for value: SROUTPUT2
            /// </summary>
            [EnumMember(Value = "SROUTPUT2")]
            SROUTPUT2 = 64,

            /// <summary>
            /// Enum CIUOUTPUT for value: CIUOUTPUT
            /// </summary>
            [EnumMember(Value = "CIUOUTPUT")]
            CIUOUTPUT = 65,

            /// <summary>
            /// Enum ZROUTPUT for value: ZROUTPUT
            /// </summary>
            [EnumMember(Value = "ZROUTPUT")]
            ZROUTPUT = 66,

            /// <summary>
            /// Enum ZREXPORT for value: ZREXPORT
            /// </summary>
            [EnumMember(Value = "ZREXPORT")]
            ZREXPORT = 67,

            /// <summary>
            /// Enum ACC28PLUS for value: ACC28PLUS
            /// </summary>
            [EnumMember(Value = "ACC28PLUS")]
            ACC28PLUS = 68,

            /// <summary>
            /// Enum ACCUPTO28 for value: ACCUPTO28
            /// </summary>
            [EnumMember(Value = "ACCUPTO28")]
            ACCUPTO28 = 69,

            /// <summary>
            /// Enum OTHEROUTPUT for value: OTHEROUTPUT
            /// </summary>
            [EnumMember(Value = "OTHEROUTPUT")]
            OTHEROUTPUT = 70,

            /// <summary>
            /// Enum SHOUTPUT for value: SHOUTPUT
            /// </summary>
            [EnumMember(Value = "SHOUTPUT")]
            SHOUTPUT = 71,

            /// <summary>
            /// Enum ZRINPUT for value: ZRINPUT
            /// </summary>
            [EnumMember(Value = "ZRINPUT")]
            ZRINPUT = 72,

            /// <summary>
            /// Enum BADDEBT for value: BADDEBT
            /// </summary>
            [EnumMember(Value = "BADDEBT")]
            BADDEBT = 73,

            /// <summary>
            /// Enum OTHERINPUT for value: OTHERINPUT
            /// </summary>
            [EnumMember(Value = "OTHERINPUT")]
            OTHERINPUT = 74,

            /// <summary>
            /// Enum BADDEBTRELIEF for value: BADDEBTRELIEF
            /// </summary>
            [EnumMember(Value = "BADDEBTRELIEF")]
            BADDEBTRELIEF = 75,

            /// <summary>
            /// Enum IGDSINPUT3 for value: IGDSINPUT3
            /// </summary>
            [EnumMember(Value = "IGDSINPUT3")]
            IGDSINPUT3 = 76,

            /// <summary>
            /// Enum SROVR for value: SROVR
            /// </summary>
            [EnumMember(Value = "SROVR")]
            SROVR = 77,

            /// <summary>
            /// Enum TOURISTREFUND for value: TOURISTREFUND
            /// </summary>
            [EnumMember(Value = "TOURISTREFUND")]
            TOURISTREFUND = 78,

            /// <summary>
            /// Enum TXRCN33 for value: TXRCN33
            /// </summary>
            [EnumMember(Value = "TXRCN33")]
            TXRCN33 = 79,

            /// <summary>
            /// Enum TXRCRE for value: TXRCRE
            /// </summary>
            [EnumMember(Value = "TXRCRE")]
            TXRCRE = 80,

            /// <summary>
            /// Enum TXRCESS for value: TXRCESS
            /// </summary>
            [EnumMember(Value = "TXRCESS")]
            TXRCESS = 81,

            /// <summary>
            /// Enum TXRCTS for value: TXRCTS
            /// </summary>
            [EnumMember(Value = "TXRCTS")]
            TXRCTS = 82,

            /// <summary>
            /// Enum CAPEXINPUT for value: CAPEXINPUT
            /// </summary>
            [EnumMember(Value = "CAPEXINPUT")]
            CAPEXINPUT = 83,

            /// <summary>
            /// Enum UNDEFINED for value: UNDEFINED
            /// </summary>
            [EnumMember(Value = "UNDEFINED")]
            UNDEFINED = 84,

            /// <summary>
            /// Enum CAPEXOUTPUT for value: CAPEXOUTPUT
            /// </summary>
            [EnumMember(Value = "CAPEXOUTPUT")]
            CAPEXOUTPUT = 85,

            /// <summary>
            /// Enum ZEROEXPOUTPUT for value: ZEROEXPOUTPUT
            /// </summary>
            [EnumMember(Value = "ZEROEXPOUTPUT")]
            ZEROEXPOUTPUT = 86,

            /// <summary>
            /// Enum GOODSIMPORT for value: GOODSIMPORT
            /// </summary>
            [EnumMember(Value = "GOODSIMPORT")]
            GOODSIMPORT = 87,

            /// <summary>
            /// Enum NONEINPUT for value: NONEINPUT
            /// </summary>
            [EnumMember(Value = "NONEINPUT")]
            NONEINPUT = 88,

            /// <summary>
            /// Enum NOTREPORTED for value: NOTREPORTED
            /// </summary>
            [EnumMember(Value = "NOTREPORTED")]
            NOTREPORTED = 89,

            /// <summary>
            /// Enum SROVRRS for value: SROVRRS
            /// </summary>
            [EnumMember(Value = "SROVRRS")]
            SROVRRS = 90,

            /// <summary>
            /// Enum SROVRLVG for value: SROVRLVG
            /// </summary>
            [EnumMember(Value = "SROVRLVG")]
            SROVRLVG = 91,

            /// <summary>
            /// Enum SRLVG for value: SRLVG
            /// </summary>
            [EnumMember(Value = "SRLVG")]
            SRLVG = 92,

            /// <summary>
            /// Enum IM for value: IM
            /// </summary>
            [EnumMember(Value = "IM")]
            IM = 93,

            /// <summary>
            /// Enum IMESS for value: IMESS
            /// </summary>
            [EnumMember(Value = "IMESS")]
            IMESS = 94,

            /// <summary>
            /// Enum IMN33 for value: IMN33
            /// </summary>
            [EnumMember(Value = "IMN33")]
            IMN33 = 95,

            /// <summary>
            /// Enum IMRE for value: IMRE
            /// </summary>
            [EnumMember(Value = "IMRE")]
            IMRE = 96,

            /// <summary>
            /// Enum BADDEBTRECOVERY for value: BADDEBTRECOVERY
            /// </summary>
            [EnumMember(Value = "BADDEBTRECOVERY")]
            BADDEBTRECOVERY = 97

        }

        /// <summary>
        /// See ReportTaxTypes
        /// </summary>
        /// <value>See ReportTaxTypes</value>
        [DataMember(Name="ReportTaxType", EmitDefaultValue=false)]
        public ReportTaxTypeEnum ReportTaxType { get; set; }
        
        /// <summary>
        /// Name of tax rate
        /// </summary>
        /// <value>Name of tax rate</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The tax type
        /// </summary>
        /// <value>The tax type</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// See TaxComponents
        /// </summary>
        /// <value>See TaxComponents</value>
        [DataMember(Name="TaxComponents", EmitDefaultValue=false)]
        public List<TaxComponent> TaxComponents { get; set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for asset accounts i.e.  true,false
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for asset accounts i.e.  true,false</value>
        [DataMember(Name="CanApplyToAssets", EmitDefaultValue=false)]
        public bool? CanApplyToAssets { get; private set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for equity accounts i.e true,false
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for equity accounts i.e true,false</value>
        [DataMember(Name="CanApplyToEquity", EmitDefaultValue=false)]
        public bool? CanApplyToEquity { get; private set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for expense accounts  i.e. true,false
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for expense accounts  i.e. true,false</value>
        [DataMember(Name="CanApplyToExpenses", EmitDefaultValue=false)]
        public bool? CanApplyToExpenses { get; private set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for liability accounts  i.e. true,false
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for liability accounts  i.e. true,false</value>
        [DataMember(Name="CanApplyToLiabilities", EmitDefaultValue=false)]
        public bool? CanApplyToLiabilities { get; private set; }

        /// <summary>
        /// Boolean to describe if tax rate can be used for revenue accounts i.e. true,false
        /// </summary>
        /// <value>Boolean to describe if tax rate can be used for revenue accounts i.e. true,false</value>
        [DataMember(Name="CanApplyToRevenue", EmitDefaultValue=false)]
        public bool? CanApplyToRevenue { get; private set; }

        /// <summary>
        /// Tax Rate (decimal to 4dp) e.g 12.5000
        /// </summary>
        /// <value>Tax Rate (decimal to 4dp) e.g 12.5000</value>
        [DataMember(Name="DisplayTaxRate", EmitDefaultValue=false)]
        public decimal? DisplayTaxRate { get; private set; }

        /// <summary>
        /// Effective Tax Rate (decimal to 4dp) e.g 12.5000
        /// </summary>
        /// <value>Effective Tax Rate (decimal to 4dp) e.g 12.5000</value>
        [DataMember(Name="EffectiveRate", EmitDefaultValue=false)]
        public decimal? EffectiveRate { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxComponents: ").Append(TaxComponents).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReportTaxType: ").Append(ReportTaxType).Append("\n");
            sb.Append("  CanApplyToAssets: ").Append(CanApplyToAssets).Append("\n");
            sb.Append("  CanApplyToEquity: ").Append(CanApplyToEquity).Append("\n");
            sb.Append("  CanApplyToExpenses: ").Append(CanApplyToExpenses).Append("\n");
            sb.Append("  CanApplyToLiabilities: ").Append(CanApplyToLiabilities).Append("\n");
            sb.Append("  CanApplyToRevenue: ").Append(CanApplyToRevenue).Append("\n");
            sb.Append("  DisplayTaxRate: ").Append(DisplayTaxRate).Append("\n");
            sb.Append("  EffectiveRate: ").Append(EffectiveRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxRate);
        }

        /// <summary>
        /// Returns true if TaxRate instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.TaxComponents == input.TaxComponents ||
                    this.TaxComponents != null &&
                    input.TaxComponents != null &&
                    this.TaxComponents.SequenceEqual(input.TaxComponents)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ReportTaxType == input.ReportTaxType ||
                    this.ReportTaxType.Equals(input.ReportTaxType)
                ) && 
                (
                    this.CanApplyToAssets == input.CanApplyToAssets ||
                    (this.CanApplyToAssets != null &&
                    this.CanApplyToAssets.Equals(input.CanApplyToAssets))
                ) && 
                (
                    this.CanApplyToEquity == input.CanApplyToEquity ||
                    (this.CanApplyToEquity != null &&
                    this.CanApplyToEquity.Equals(input.CanApplyToEquity))
                ) && 
                (
                    this.CanApplyToExpenses == input.CanApplyToExpenses ||
                    (this.CanApplyToExpenses != null &&
                    this.CanApplyToExpenses.Equals(input.CanApplyToExpenses))
                ) && 
                (
                    this.CanApplyToLiabilities == input.CanApplyToLiabilities ||
                    (this.CanApplyToLiabilities != null &&
                    this.CanApplyToLiabilities.Equals(input.CanApplyToLiabilities))
                ) && 
                (
                    this.CanApplyToRevenue == input.CanApplyToRevenue ||
                    (this.CanApplyToRevenue != null &&
                    this.CanApplyToRevenue.Equals(input.CanApplyToRevenue))
                ) && 
                (
                    this.DisplayTaxRate == input.DisplayTaxRate ||
                    (this.DisplayTaxRate != null &&
                    this.DisplayTaxRate.Equals(input.DisplayTaxRate))
                ) && 
                (
                    this.EffectiveRate == input.EffectiveRate ||
                    (this.EffectiveRate != null &&
                    this.EffectiveRate.Equals(input.EffectiveRate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.TaxComponents != null)
                    hashCode = hashCode * 59 + this.TaxComponents.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ReportTaxType.GetHashCode();
                if (this.CanApplyToAssets != null)
                    hashCode = hashCode * 59 + this.CanApplyToAssets.GetHashCode();
                if (this.CanApplyToEquity != null)
                    hashCode = hashCode * 59 + this.CanApplyToEquity.GetHashCode();
                if (this.CanApplyToExpenses != null)
                    hashCode = hashCode * 59 + this.CanApplyToExpenses.GetHashCode();
                if (this.CanApplyToLiabilities != null)
                    hashCode = hashCode * 59 + this.CanApplyToLiabilities.GetHashCode();
                if (this.CanApplyToRevenue != null)
                    hashCode = hashCode * 59 + this.CanApplyToRevenue.GetHashCode();
                if (this.DisplayTaxRate != null)
                    hashCode = hashCode * 59 + this.DisplayTaxRate.GetHashCode();
                if (this.EffectiveRate != null)
                    hashCode = hashCode * 59 + this.EffectiveRate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
