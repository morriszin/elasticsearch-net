// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Analysis
{
	public class SpecifyAnalyzerPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("analysis/specify-analyzer.asciidoc:50")]
		public void Line50()
		{
			// tag::311c6e60a020df4e301c6db9bcaf9e0a[]
			var response0 = new SearchResponse<object>();
			// end::311c6e60a020df4e301c6db9bcaf9e0a[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""mappings"": {
			    ""properties"": {
			      ""title"": {
			        ""type"": ""text"",
			        ""analyzer"": ""whitespace""
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/specify-analyzer.asciidoc:74")]
		public void Line74()
		{
			// tag::7b2c75b4f6150485593c49f96f05fb2f[]
			var response0 = new SearchResponse<object>();
			// end::7b2c75b4f6150485593c49f96f05fb2f[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""default"": {
			          ""type"": ""simple""
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/specify-analyzer.asciidoc:130")]
		public void Line130()
		{
			// tag::040e4b4d0119e4cc94eafb9db91baae5[]
			var response0 = new SearchResponse<object>();
			// end::040e4b4d0119e4cc94eafb9db91baae5[]

			response0.MatchesExample(@"GET my_index/_search
			{
			  ""query"": {
			    ""match"": {
			      ""message"": {
			        ""query"": ""Quick foxes"",
			        ""analyzer"": ""stop""
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/specify-analyzer.asciidoc:158")]
		public void Line158()
		{
			// tag::8870b188fd9471b853f03cbc2a312261[]
			var response0 = new SearchResponse<object>();
			// end::8870b188fd9471b853f03cbc2a312261[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""mappings"": {
			    ""properties"": {
			      ""title"": {
			        ""type"": ""text"",
			        ""analyzer"": ""whitespace"",
			        ""search_analyzer"": ""simple""
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		[Description("analysis/specify-analyzer.asciidoc:186")]
		public void Line186()
		{
			// tag::77c1e9a95f91229bc3f4ede13af97d34[]
			var response0 = new SearchResponse<object>();
			// end::77c1e9a95f91229bc3f4ede13af97d34[]

			response0.MatchesExample(@"PUT my_index
			{
			  ""settings"": {
			    ""analysis"": {
			      ""analyzer"": {
			        ""default"": {
			          ""type"": ""simple""
			        },
			        ""default_search"": {
			          ""type"": ""whitespace""
			        }
			      }
			    }
			  }
			}");
		}
	}
}
