/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.8.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// EmployeeLeaveSetup
    /// </summary>
    [DataContract]
    public partial class EmployeeLeaveSetup :  IEquatable<EmployeeLeaveSetup>, IValidatableObject
    {
        
        /// <summary>
        /// Identifier if holiday pay will be included in each payslip
        /// </summary>
        /// <value>Identifier if holiday pay will be included in each payslip</value>
        [DataMember(Name="includeHolidayPay", EmitDefaultValue=false)]
        public bool? IncludeHolidayPay { get; set; }

        /// <summary>
        /// Initial holiday pay balance. A percentage — usually 8% — of gross earnings since their last work anniversary.
        /// </summary>
        /// <value>Initial holiday pay balance. A percentage — usually 8% — of gross earnings since their last work anniversary.</value>
        [DataMember(Name="holidayPayOpeningBalance", EmitDefaultValue=false)]
        public decimal? HolidayPayOpeningBalance { get; set; }

        /// <summary>
        /// Initial annual leave balance. The balance at their last anniversary, less any leave taken since then and excluding accrued annual leave.
        /// </summary>
        /// <value>Initial annual leave balance. The balance at their last anniversary, less any leave taken since then and excluding accrued annual leave.</value>
        [DataMember(Name="annualLeaveOpeningBalance", EmitDefaultValue=false)]
        public decimal? AnnualLeaveOpeningBalance { get; set; }

        /// <summary>
        /// The dollar value of annual leave opening balance if negative.
        /// </summary>
        /// <value>The dollar value of annual leave opening balance if negative.</value>
        [DataMember(Name="negativeAnnualLeaveBalancePaidAmount", EmitDefaultValue=false)]
        public decimal? NegativeAnnualLeaveBalancePaidAmount { get; set; }

        /// <summary>
        /// Number of hours accrued annually for sick leave. Multiply the number of days they&#39;re entitled to by the hours worked per day
        /// </summary>
        /// <value>Number of hours accrued annually for sick leave. Multiply the number of days they&#39;re entitled to by the hours worked per day</value>
        [DataMember(Name="sickLeaveHoursToAccrueAnnually", EmitDefaultValue=false)]
        public decimal? SickLeaveHoursToAccrueAnnually { get; set; }

        /// <summary>
        /// Maximum number of hours accrued annually for sick leave. Multiply the maximum days they can accrue by the hours worked per day
        /// </summary>
        /// <value>Maximum number of hours accrued annually for sick leave. Multiply the maximum days they can accrue by the hours worked per day</value>
        [DataMember(Name="sickLeaveMaximumHoursToAccrue", EmitDefaultValue=false)]
        public decimal? SickLeaveMaximumHoursToAccrue { get; set; }

        /// <summary>
        /// Initial sick leave balance. This will be positive unless they&#39;ve taken sick leave in advance
        /// </summary>
        /// <value>Initial sick leave balance. This will be positive unless they&#39;ve taken sick leave in advance</value>
        [DataMember(Name="sickLeaveOpeningBalance", EmitDefaultValue=false)]
        public decimal? SickLeaveOpeningBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeLeaveSetup {\n");
            sb.Append("  IncludeHolidayPay: ").Append(IncludeHolidayPay).Append("\n");
            sb.Append("  HolidayPayOpeningBalance: ").Append(HolidayPayOpeningBalance).Append("\n");
            sb.Append("  AnnualLeaveOpeningBalance: ").Append(AnnualLeaveOpeningBalance).Append("\n");
            sb.Append("  NegativeAnnualLeaveBalancePaidAmount: ").Append(NegativeAnnualLeaveBalancePaidAmount).Append("\n");
            sb.Append("  SickLeaveHoursToAccrueAnnually: ").Append(SickLeaveHoursToAccrueAnnually).Append("\n");
            sb.Append("  SickLeaveMaximumHoursToAccrue: ").Append(SickLeaveMaximumHoursToAccrue).Append("\n");
            sb.Append("  SickLeaveOpeningBalance: ").Append(SickLeaveOpeningBalance).Append("\n");
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
            return this.Equals(input as EmployeeLeaveSetup);
        }

        /// <summary>
        /// Returns true if EmployeeLeaveSetup instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeLeaveSetup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeLeaveSetup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeHolidayPay == input.IncludeHolidayPay ||
                    this.IncludeHolidayPay.Equals(input.IncludeHolidayPay)
                ) && 
                (
                    this.HolidayPayOpeningBalance == input.HolidayPayOpeningBalance ||
                    this.HolidayPayOpeningBalance.Equals(input.HolidayPayOpeningBalance)
                ) && 
                (
                    this.AnnualLeaveOpeningBalance == input.AnnualLeaveOpeningBalance ||
                    this.AnnualLeaveOpeningBalance.Equals(input.AnnualLeaveOpeningBalance)
                ) && 
                (
                    this.NegativeAnnualLeaveBalancePaidAmount == input.NegativeAnnualLeaveBalancePaidAmount ||
                    this.NegativeAnnualLeaveBalancePaidAmount.Equals(input.NegativeAnnualLeaveBalancePaidAmount)
                ) && 
                (
                    this.SickLeaveHoursToAccrueAnnually == input.SickLeaveHoursToAccrueAnnually ||
                    this.SickLeaveHoursToAccrueAnnually.Equals(input.SickLeaveHoursToAccrueAnnually)
                ) && 
                (
                    this.SickLeaveMaximumHoursToAccrue == input.SickLeaveMaximumHoursToAccrue ||
                    this.SickLeaveMaximumHoursToAccrue.Equals(input.SickLeaveMaximumHoursToAccrue)
                ) && 
                (
                    this.SickLeaveOpeningBalance == input.SickLeaveOpeningBalance ||
                    this.SickLeaveOpeningBalance.Equals(input.SickLeaveOpeningBalance)
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
                hashCode = hashCode * 59 + this.IncludeHolidayPay.GetHashCode();
                hashCode = hashCode * 59 + this.HolidayPayOpeningBalance.GetHashCode();
                hashCode = hashCode * 59 + this.AnnualLeaveOpeningBalance.GetHashCode();
                hashCode = hashCode * 59 + this.NegativeAnnualLeaveBalancePaidAmount.GetHashCode();
                hashCode = hashCode * 59 + this.SickLeaveHoursToAccrueAnnually.GetHashCode();
                hashCode = hashCode * 59 + this.SickLeaveMaximumHoursToAccrue.GetHashCode();
                hashCode = hashCode * 59 + this.SickLeaveOpeningBalance.GetHashCode();
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
