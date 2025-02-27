﻿using Dhl.Helpers;
using Sharprompt;


var model = Prompt.Bind<PromptModel>();

if (model.PutSolutionAndProjectInSamePlace == false)
{
    var solutionName = Prompt.Input<string>("please enter solution name");
    model.SetSolutionName(solutionName);
}

SolutionHelper.CreateSolution(model);

TemplateHelper.CreateProjectBasedOnTemplate(model);

SolutionHelper.LinkProjectToSolution(model);

ReadmeHelper.AddReadmeFile(model);
GitHelper.AddGitToSolution(model);