﻿using System;
using System.ComponentModel.DataAnnotations;
using ApiMultiPartFormData.Models;

namespace MultipartFormDataMyGet.ViewModels
{
    public class BasicUploadViewModel
    {
        #region Properties

        public Guid Id { get; set; }

        /// <summary>
        /// Attachment.
        /// </summary>
        [Required]
        public HttpFile Attachment { get; set; }

        #endregion
    }
}