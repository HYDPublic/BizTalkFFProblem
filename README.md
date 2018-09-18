# Overview
The solution can be deployed by the BizTalk Deployment Framework.
Only thing that will need changing is the values fro SsoAppUserGroup and SsoAppAdminGroup which can be found in the environmentsettings.xml file (open with Excel).

The receive location collects a tab delimited file - SampleEmployees.csv. It should be processed by the FF disassembler which would debatch each record into an individual xml document. These are subscribed to be the send port and sent to a local folder.

The only slightly unusual thing about the SamEmployee_FF.xsd is that the last element "PostStartDate" has a micOccurs attribute value of 0. This is becuse there are a couple of providers of these document and one of the providers doesn't include a "PostStartDate" column.

# Problem
If the final record in the processed file contains a line feed then it will be suspended. The event log will contain an error like *"Flat file disassembler" Receive Port: "ReceiveEmployee" URI: "D:\FileDrop\Employees\In\*.csv" Reason: Unexpected data found while looking for:
'\t'
The current definition being parsed is Employee. The stream offset where the error occured is 2682. The line number where the error occured is 13. The column where the error occured is 0.*
