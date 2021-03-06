using GraphQL.Common.Tests.Model;
using Xunit;

namespace GraphQL.Common.Tests.Response {

	public class GraphQLResponseTests {

		[Fact]
		public void FieldsResponse1Fact() {
			var graphQLResponse = GraphQLResponseConsts.FieldsResponse1;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
		}

		[Fact]
		public void FieldsResponse2Fact() {
			var graphQLResponse = GraphQLResponseConsts.FieldsResponse2;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);
			Assert.Equal("Luke Skywalker", graphQLResponse.Data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void ArgumentsResponse1Fact() {
			var graphQLResponse = GraphQLResponseConsts.ArgumentsResponse1;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", graphQLResponse.Data.human.name.Value);
			Assert.Equal(1.72, graphQLResponse.Data.human.height.Value);

			var human = graphQLResponse.GetDataFieldAs<Person>("human");
			Assert.Equal("Luke Skywalker", human.Name);
			Assert.Equal(1.72, human.Height);
		}

		[Fact]
		public void ArgumentsResponse2Fact() {
			var graphQLResponse = GraphQLResponseConsts.ArgumentsResponse2;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", graphQLResponse.Data.human.name.Value);
			Assert.Equal(5.6430448, graphQLResponse.Data.human.height.Value);

			var human = graphQLResponse.GetDataFieldAs<Person>("human");
			Assert.Equal("Luke Skywalker", human.Name);
			Assert.Equal(5.6430448, human.Height);
		}

		[Fact]
		public void AliasesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.AliasesResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", graphQLResponse.Data.empireHero.name.Value);
			Assert.Equal("R2-D2", graphQLResponse.Data.jediHero.name.Value);

			var empireHero = graphQLResponse.GetDataFieldAs<Person>("empireHero");
			Assert.Equal("Luke Skywalker", empireHero.Name);

			var jediHero = graphQLResponse.GetDataFieldAs<Person>("jediHero");
			Assert.Equal("R2-D2", jediHero.Name);
		}

		[Fact]
		public void FragmentsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.FragmentsResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Luke Skywalker", graphQLResponse.Data.leftComparison.name.Value);
			Assert.Equal("NEWHOPE", graphQLResponse.Data.leftComparison.appearsIn[0].Value);
			Assert.Equal("EMPIRE", graphQLResponse.Data.leftComparison.appearsIn[1].Value);
			Assert.Equal("JEDI", graphQLResponse.Data.leftComparison.appearsIn[2].Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.leftComparison.friends[0].name.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.leftComparison.friends[1].name.Value);
			Assert.Equal("C-3PO", graphQLResponse.Data.leftComparison.friends[2].name.Value);
			Assert.Equal("R2-D2", graphQLResponse.Data.leftComparison.friends[3].name.Value);

			Assert.Equal("R2-D2", graphQLResponse.Data.rightComparison.name.Value);
			Assert.Equal("NEWHOPE", graphQLResponse.Data.rightComparison.appearsIn[0].Value);
			Assert.Equal("EMPIRE", graphQLResponse.Data.rightComparison.appearsIn[1].Value);
			Assert.Equal("JEDI", graphQLResponse.Data.rightComparison.appearsIn[2].Value);
			Assert.Equal("Luke Skywalker", graphQLResponse.Data.rightComparison.friends[0].name.Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.rightComparison.friends[1].name.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.rightComparison.friends[2].name.Value);

			var leftComparison = graphQLResponse.GetDataFieldAs<Person>("leftComparison");
			Assert.Equal("Luke Skywalker", leftComparison.Name);
			Assert.Equal("NEWHOPE", leftComparison.AppearsIn[0]);
			Assert.Equal("EMPIRE", leftComparison.AppearsIn[1]);
			Assert.Equal("JEDI", leftComparison.AppearsIn[2]);
			Assert.Equal("Han Solo", leftComparison.Friends[0].Name);
			Assert.Equal("Leia Organa", leftComparison.Friends[1].Name);
			Assert.Equal("C-3PO", leftComparison.Friends[2].Name);
			Assert.Equal("R2-D2", leftComparison.Friends[3].Name);

			var rightComparison = graphQLResponse.GetDataFieldAs<Person>("rightComparison");
			Assert.Equal("R2-D2", rightComparison.Name);
			Assert.Equal("NEWHOPE", rightComparison.AppearsIn[0]);
			Assert.Equal("EMPIRE", rightComparison.AppearsIn[1]);
			Assert.Equal("JEDI", rightComparison.AppearsIn[2]);
			Assert.Equal("Luke Skywalker", rightComparison.Friends[0].Name);
			Assert.Equal("Han Solo", rightComparison.Friends[1].Name);
			Assert.Equal("Leia Organa", rightComparison.Friends[2].Name);
		}

		[Fact]
		public void OperationNameResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.OperationNameResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);
			Assert.Equal("Luke Skywalker", graphQLResponse.Data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void VariablesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.VariablesResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);
			Assert.Equal("Luke Skywalker", graphQLResponse.Data.hero.friends[0].name.Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.hero.friends[1].name.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.hero.friends[2].name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Luke Skywalker", hero.Friends[0].Name);
			Assert.Equal("Han Solo", hero.Friends[1].Name);
			Assert.Equal("Leia Organa", hero.Friends[2].Name);
		}

		[Fact]
		public void DirectivesResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.DirectivesResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
		}

		[Fact]
		public void MutationsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.MutationsResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal(5, graphQLResponse.Data.createReview.stars.Value);
			Assert.Equal("This is a great movie!", graphQLResponse.Data.createReview.commentary.Value);
		}

		[Fact]
		public void InlineFragmentsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.InlineFragmentsResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("R2-D2", graphQLResponse.Data.hero.name.Value);
			Assert.Equal("Astromech", graphQLResponse.Data.hero.primaryFunction.Value);

			var hero = graphQLResponse.GetDataFieldAs<Person>("hero");
			Assert.Equal("R2-D2", hero.Name);
			Assert.Equal("Astromech", hero.PrimaryFunction);
		}

		[Fact]
		public void MetaFieldsResponseFact() {
			var graphQLResponse = GraphQLResponseConsts.MetaFieldsResponse;
			AssertGraphQL.CorrectGraphQLResponse(graphQLResponse);

			Assert.Equal("Human", graphQLResponse.Data.search[0].__typename.Value);
			Assert.Equal("Han Solo", graphQLResponse.Data.search[0].name.Value);
			Assert.Equal("Human", graphQLResponse.Data.search[1].__typename.Value);
			Assert.Equal("Leia Organa", graphQLResponse.Data.search[1].name.Value);
			Assert.Equal("Starship", graphQLResponse.Data.search[2].__typename.Value);
			Assert.Equal("TIE Advanced x1", graphQLResponse.Data.search[2].name.Value);
		}

	}

}
