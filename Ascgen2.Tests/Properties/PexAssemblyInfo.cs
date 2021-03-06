// <copyright file="PexAssemblyInfo.cs" company="Jonathan Mathews Software">Jonathan Mathews</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Ascgen2")]
[assembly: PexInstrumentAssembly("Browser")]
[assembly: PexInstrumentAssembly("JMSoftware.TextHelper")]
[assembly: PexInstrumentAssembly("JMSoftware.ImageHelper")]
[assembly: PexInstrumentAssembly("JMSoftware.VersionChecking")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]
[assembly: PexInstrumentAssembly("JMSoftware.Controls")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Browser")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "JMSoftware.TextHelper")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "JMSoftware.ImageHelper")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "JMSoftware.VersionChecking")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "JMSoftware.Controls")]

