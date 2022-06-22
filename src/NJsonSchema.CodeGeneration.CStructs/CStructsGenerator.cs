namespace NJsonSchema.CodeGeneration.CStructs
{
    public class CStructsGenerator : GeneratorBase
    {
        public CStructsGenerator(object rootObject, TypeResolverBase typeResolver, CodeGeneratorSettingsBase settings) : base(rootObject, typeResolver, settings)
        {
        }

        protected override string GenerateFile(IEnumerable<CodeArtifact> artifacts)
        {
            return string.Empty;
        }

        protected override CodeArtifact GenerateType(JsonSchema schema, string typeNameHint)
        {
            return new CodeArtifact("test", CodeArtifactType.Class, CodeArtifactLanguage.CSharp, CodeArtifactCategory.Contract, "struct");
        }
    }
}