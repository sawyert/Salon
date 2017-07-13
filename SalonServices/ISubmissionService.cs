﻿using SalonServices.Dto.Submission;
using SalonServices.Dto.Submission.Submission;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalonServices
{
    public interface ISubmissionService
    {
        Task<SubmissionSaveDto> CreateSubmission(SubmissionSaveDto pCreateSubmission);
        Task<SubmissionResultsDto> GetSubmissionResults(int pSubmissionId);
        Task UpdateSubmissionResults(SubmissionResultsDto pSubmissionResults);


    }
}
