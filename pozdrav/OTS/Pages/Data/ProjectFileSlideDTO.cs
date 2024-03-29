﻿namespace pozdrav.OTS.Pages.Data
{
	public class ProjectFileSlideDTO : SlideDTO
	{
		public string Content { get; init; }

		public ProjectFileSlideDTO(string caption, string content)
			: base("ProjectFileSlide", caption)
		{
			Content = content;
		}
	}
}
