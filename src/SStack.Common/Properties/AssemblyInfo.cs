using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SStack.Common")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("SStack")]
[assembly: AssemblyProduct("SStack.Common")]
[assembly: AssemblyCopyright("Copyright � SStack 2013")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3871f659-64fb-4dfb-a49f-17dc2f8a47e2")]

[assembly: AssemblyVersion("1.0.0.0")]

// CCB Custom
[assembly: ContractNamespace("http://schemas.SStack.net/types",
 ClrNamespace = "SStack.Common.ServiceClient.Web")]

[assembly: ContractNamespace("http://schemas.SStack.net/types",
 ClrNamespace = "SStack.Common.ServiceModel")]

[assembly: InternalsVisibleTo("SStack.Common.Tests")]
