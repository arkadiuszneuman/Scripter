using System.ComponentModel;

namespace Skryper.Interface
{
    public interface I_ScriptOptions
    {
        [Description("bla bal")]
        bool AgentAlertJob { get; set; }

        [Description("bla bal")]
        bool AgentJobId { get; set; }

        [Description("bla bal")]
        bool AgentNotify { get; set; }

        [Description("bla bal")]
        bool AllowSystemObjects { get; set; }

        [Description("bla bal")]
        bool AnsiFile { get; set; }

        [Description("bla bal")]
        bool AnsiPadding { get; set; }

        [Description("bla bal")]
        bool AppendToFile { get; set; }

        [Description("bla bal")]
        bool Bindings { get; set; }

        [Description("bla bal")]
        bool ChangeTracking { get; set; }

        [Description("bla bal")]
        bool ClusteredIndexes { get; set; }

        [Description("bla bal")]
        bool ContinueScriptingOnError { get; set; }

        [Description("bla bal")]
        bool ConvertUserDefinedDataTypesToBaseType { get; set; }

        [Description("bla bal")]
        bool DdlBodyOnly { get; set; }

        [Description("bla bal")]
        bool DdlHeaderOnly { get; set; }

        [Description("bla bal")]
        bool Default { get; set; }

        [Description("bla bal")]
        bool DriAll { get; set; }

        [Description("bla bal")]
        bool DriAllKeys { get; set; }

        [Description("bla bal")]
        bool DriChecks { get; set; }

        [Description("bla bal")]
        bool DriClustered { get; set; }

        [Description("bla bal")]
        bool DriDefaults { get; set; }

        [Description("bla bal")]
        bool DriForeignKeys { get; set; }

        [Description("bla bal")]
        bool DriIncludeSystemNames { get; set; }

        [Description("bla bal")]
        bool DriIndexes { get; set; }

        [Description("bla bal")]
        bool DriNonClustered { get; set; }

        [Description("bla bal")]
        bool DriPrimaryKey { get; set; }

        [Description("bla bal")]
        bool DriUniqueKeys { get; set; }

        [Description("bla bal")]
        bool DriWithNoCheck { get; set; }

        [Description("bla bal")]
        bool EnforceScriptingOptions { get; set; }

        [Description("bla bal")]
        bool ExtendedProperties { get; set; }

        [Description("bla bal")]
        bool FullTextCatalogs { get; set; }

        [Description("bla bal")]
        bool FullTextIndexes { get; set; }

        [Description("bla bal")]
        bool FullTextStopLists { get; set; }

        [Description("bla bal")]
        bool IncludeDatabaseContext { get; set; }

        [Description("bla bal")]
        bool IncludeDatabaseRoleMemberships { get; set; }

        [Description("bla bal")]
        bool IncludeFullTextCatalogRootPath { get; set; }

        [Description("bla bal")]
        bool IncludeHeaders { get; set; }

        [Description("bla bal")]
        bool IncludeIfNotExists { get; set; }

        [Description("bla bal")]
        bool Indexes { get; set; }

        [Description("bla bal")]
        bool LoginSid { get; set; }

        [Description("bla bal")]
        bool NoAssemblies { get; set; }

        [Description("bla bal")]
        bool NoCollation { get; set; }

        [Description("bla bal")]
        bool NoCommandTerminator { get; set; }

        [Description("bla bal")]
        bool NoExecuteAs { get; set; }

        [Description("bla bal")]
        bool NoFileGroup { get; set; }

        [Description("bla bal")]
        bool NoFileStream { get; set; }

        [Description("bla bal")]
        bool NoFileStreamColumn { get; set; }

        [Description("bla bal")]
        bool NoIdentities { get; set; }

        [Description("bla bal")]
        bool NoIndexPartitioningSchemes { get; set; }

        [Description("bla bal")]
        bool NoVardecimal { get; set; }

        [Description("bla bal")]
        bool NoViewColumns { get; set; }

        [Description("bla bal")]
        bool NoXmlNamespaces { get; set; }

        [Description("bla bal")]
        bool OptimizerData { get; set; }

        [Description("bla bal")]
        bool Permissions { get; set; }

        [Description("bla bal")]
        bool PrimaryObject { get; set; }

        [Description("bla bal")]
        bool SchemaQualify { get; set; }

        [Description("bla bal")]
        bool SchemaQualifyForeignKeysReferences { get; set; }

        [Description("bla bal")]
        bool ScriptBatchTerminator { get; set; }

        [Description("bla bal")]
        bool ScriptData { get; set; }

        [Description("bla bal")]
        bool ScriptDataCompression { get; set; }

        [Description("bla bal")]
        bool ScriptOwner { get; set; }

        [Description("bla bal")]
        bool ScriptSchema { get; set; }

        [Description("bla bal")]
        bool Statistics { get; set; }

        [Description("bla bal")]
        bool TimestampToBinary { get; set; }

        [Description("bla bal")]
        bool ToFileOnly { get; set; }

        [Description("bla bal")]
        bool Triggers { get; set; }

        [Description("bla bal")]
        bool WithDependencies { get; set; }

        [Description("bla bal")]
        bool XmlIndexes { get; set; }

    }
}