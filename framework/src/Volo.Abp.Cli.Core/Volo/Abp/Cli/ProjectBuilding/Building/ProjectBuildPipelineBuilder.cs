﻿using System;
using Volo.Abp.Cli.ProjectBuilding.Building.Steps;
using Volo.Abp.Cli.ProjectBuilding.Templates.App;

namespace Volo.Abp.Cli.ProjectBuilding.Building
{
    public static class ProjectBuildPipelineBuilder
    {
        public static ProjectBuildPipeline Build(ProjectBuildContext context)
        {
            var pipeline = new ProjectBuildPipeline(context);

            pipeline.Steps.Add(new FileEntryListReadStep());

            pipeline.Steps.AddRange(context.Template.GetCustomSteps(context));
            
            if (!context.BuildArgs.ExtraProperties.ContainsKey("local-framework-ref") ||
                !string.IsNullOrWhiteSpace(context.BuildArgs.GitHubLocalRepositoryPath))
            {
                pipeline.Steps.Add(new NugetReferenceReplaceStep());
            }

            pipeline.Steps.Add(new TemplateCodeDeleteStep());
            pipeline.Steps.Add(new SolutionRenameStep());

            if (context.Template.Name == AppProTemplate.TemplateName)
            {
                pipeline.Steps.Add(new LicenseCodeReplaceStep());
            }

            pipeline.Steps.Add(new CreateProjectResultZipStep());

            return pipeline;
        }
    }
}
