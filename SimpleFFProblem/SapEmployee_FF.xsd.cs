namespace SimpleFFProblem {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF",@"Employee")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Data.NiNumber", XPath = @"/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='NiNumber' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Data.OrgLeaveDate", XPath = @"/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='OrgLeaveDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Data.PosLeaveDate", XPath = @"/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='PosLeaveDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Data.PostStartDate", XPath = @"/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='PostStartDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Employee"})]
    public sealed class SapEmployee_FF : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo standard=""Flat File"" codepage=""65001"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""true"" early_terminate_optional_fields=""true"" allow_message_breakup_of_infix_root=""true"" compile_parse_tables=""false"" root_reference=""Employee"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Employee"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xA"" child_order=""postfix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='NiNumber' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='OrgLeaveDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='PosLeaveDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Employee' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='Data' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']/*[local-name()='PostStartDate' and namespace-uri()='http://LCC.Integration.Employees.Schemas.SAP.SapEmployee_FF']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element maxOccurs=""1"" name=""Data"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0x9"" child_order=""infix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element name=""NiNumber"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""1"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Reference"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""2"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""LastName"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""3"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""ForeName"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""4"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""LongName"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""5"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""DateOfBirth"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""6"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""LeaveDate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""7"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""PayrollNumber"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""8"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Organisation"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""9"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Directorate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""10"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Service"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""11"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""Team"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""12"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""SubTeam"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""13"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLevel6"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""14"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLevel7"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""15"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLevel8"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""16"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLevel9"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""17"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLevel10"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""18"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""PositionTitle"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""19"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""PosLeaveDate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""20"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element name=""OrgLeaveDate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""21"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
              <xs:element minOccurs=""0"" name=""PostStartDate"" type=""xs:string"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:fieldInfo justification=""left"" sequence_number=""22"" />
                  </xs:appinfo>
                </xs:annotation>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SapEmployee_FF() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Employee";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
