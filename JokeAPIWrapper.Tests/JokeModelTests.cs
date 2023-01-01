using JokeAPIWrapper.Models;

namespace JokeAPIWrapper.Tests;

public class JokeModelTests
{
    public sealed class TwoPartJokeTests
    {
        private readonly TwoPartJokeModel joke = new();

        private void Setup()
        {
            joke.Error = false;
            joke.Category = "Programming";
            joke.Type = "twopart";
            joke.Setup = "What's the object-oriented way to become wealthy?";
            joke.Delivery = "Inheritance.";
            joke.Flags = new Dictionary<string, bool>
        {
            { "nsfw", false },
            { "religious", false },
            { "political", false },
            { "racist", false },
            { "sexist", false },
            { "explicit", false }
        };
            joke.Id = 46;
            joke.Safe = true;
            joke.Lang = "en";
        }

        #region Getters
        [Fact]
        public void GetJokeError()
        {
            Setup();

            Assert.False(joke.Error);
        }
        [Fact]
        public void GetJokeCategory()
        {
            Setup();

            Assert.Equal(JokeCategory.Programming, joke.GetCategory());
        }
        [Fact]
        public void GetJokeType()
        {
            Setup();

            Assert.Equal("twopart", joke.Type);
        }
        [Fact]
        public void GetJokeSetup()
        {
            Setup();

            Assert.NotNull(joke.Setup);
        }
        [Fact]
        public void GetJokeDelivery()
        {
            Setup();

            Assert.NotNull(joke.Delivery);
        }
        [Fact]
        public void GetJokeFlags()
        {
            Setup();

            Assert.False(joke.Flags["nsfw"]);
            Assert.False(joke.Flags["religious"]);
            Assert.False(joke.Flags["political"]);
            Assert.False(joke.Flags["racist"]);
            Assert.False(joke.Flags["sexist"]);
            Assert.False(joke.Flags["explicit"]);
        }
        [Fact]
        public void GetJokeId()
        {
            Setup();

            Assert.Equal(46, joke.Id);
        }
        [Fact]
        public void GetJokeSafe()
        {
            Setup();

            Assert.True(joke.Safe);
        }
        [Fact]
        public void GetJokeLang()
        {
            Setup();

            Assert.Equal("en", joke.Lang);
        }
        #endregion

        #region Setters
        [Fact]
        public void SetJokeError()
        {
            Setup();

            joke.Error = true;

            Assert.True(joke.Error);
        }
        [Fact]
        public void SetJokeCategory()
        {
            Setup();

            joke.Category = "dark";

            Assert.Equal(JokeCategory.Dark, joke.GetCategory());
        }
        [Fact]
        public void SetJokeType()
        {
            Setup();

            Assert.Equal("twopart", joke.Type);
        }
        //[Fact]
        //public void GetJokeSetup()
        //{
        //    Setup();

        //    Assert.NotNull(joke.Setup);
        //}
        //[Fact]
        //public void GetJokeDelivery()
        //{
        //    Setup();

        //    Assert.NotNull(joke.Delivery);
        //}
        //[Fact]
        //public void GetJokeJoke()
        //{
        //    Setup();

        //    Assert.Null(joke.Joke);
        //}
        [Fact]
        public void SetJokeFlags()
        {
            Setup();

            joke.Flags["nsfw"] = true;

            Assert.True(joke.Flags["nsfw"]);
            Assert.False(joke.Flags["religious"]);
            Assert.False(joke.Flags["political"]);
            Assert.False(joke.Flags["racist"]);
            Assert.False(joke.Flags["sexist"]);
            Assert.False(joke.Flags["explicit"]);
        }
        [Fact]
        public void SetJokeId()
        {
            Setup();

            joke.Id = 101;

            Assert.Equal(101, joke.Id);
        }
        [Fact]
        public void SetJokeSafe()
        {
            Setup();

            joke.Safe = false;

            Assert.False(joke.Safe);
        }
        [Fact]
        public void SetJokeLang()
        {
            Setup();

            joke.Lang = "fr";

            Assert.Equal("fr", joke.Lang);
        }
        #endregion
    }

    public sealed class SingleJokeTests
    {
        private readonly SingleJokeModel joke = new();

        private void Setup()
        {
            joke.Error = false;
            joke.Category = "Programming";
            joke.Type = "single";
            joke.Joke = "If Bill Gates had a dime for every time Windows crashed ... Oh wait, he does.";
            joke.Flags = new Dictionary<string, bool>
        {
            { "nsfw", false },
            { "religious", false },
            { "political", false },
            { "racist", false },
            { "sexist", false },
            { "explicit", false }
        };
            joke.Id = 22;
            joke.Safe = true;
            joke.Lang = "en";
        }

        #region Getters
        [Fact]
        public void GetJokeError()
        {
            Setup();

            Assert.False(joke.Error);
        }
        [Fact]
        public void GetJokeCategory()
        {
            Setup();

            Assert.Equal(JokeCategory.Programming, joke.GetCategory());
        }
        [Fact]
        public void GetJokeType()
        {
            Setup();

            Assert.Equal("single", joke.Type);
        }
        [Fact]
        public void GetJokeJoke()
        {
            Setup();

            Assert.NotNull(joke.Joke);
        }
        [Fact]
        public void GetJokeFlags()
        {
            Setup();

            Assert.False(joke.Flags["nsfw"]);
            Assert.False(joke.Flags["religious"]);
            Assert.False(joke.Flags["political"]);
            Assert.False(joke.Flags["racist"]);
            Assert.False(joke.Flags["sexist"]);
            Assert.False(joke.Flags["explicit"]);
        }
        [Fact]
        public void GetJokeId()
        {
            Setup();

            Assert.Equal(22, joke.Id);
        }
        [Fact]
        public void GetJokeSafe()
        {
            Setup();

            Assert.True(joke.Safe);
        }
        [Fact]
        public void GetJokeLang()
        {
            Setup();

            Assert.Equal("en", joke.Lang);
        }
        #endregion

        #region Setters
        [Fact]
        public void SetJokeError()
        {
            Setup();

            joke.Error = true;

            Assert.True(joke.Error);
        }
        [Fact]
        public void SetJokeCategory()
        {
            Setup();

            joke.Category = "dark";

            Assert.Equal(JokeCategory.Dark, joke.GetCategory());
        }
        [Fact]
        public void SetJokeType()
        {
            Setup();

            Assert.Equal("single", joke.Type);
        }
        //[Fact]
        //public void GetJokeSetup()
        //{
        //    Setup();

        //    Assert.NotNull(joke.Setup);
        //}
        //[Fact]
        //public void GetJokeDelivery()
        //{
        //    Setup();

        //    Assert.NotNull(joke.Delivery);
        //}
        //[Fact]
        //public void GetJokeJoke()
        //{
        //    Setup();

        //    Assert.Null(joke.Joke);
        //}
        [Fact]
        public void SetJokeFlags()
        {
            Setup();

            joke.Flags["nsfw"] = true;

            Assert.True(joke.Flags["nsfw"]);
            Assert.False(joke.Flags["religious"]);
            Assert.False(joke.Flags["political"]);
            Assert.False(joke.Flags["racist"]);
            Assert.False(joke.Flags["sexist"]);
            Assert.False(joke.Flags["explicit"]);
        }
        [Fact]
        public void SetJokeId()
        {
            Setup();

            joke.Id = 101;

            Assert.Equal(101, joke.Id);
        }
        [Fact]
        public void SetJokeSafe()
        {
            Setup();

            joke.Safe = false;

            Assert.False(joke.Safe);
        }
        [Fact]
        public void SetJokeLang()
        {
            Setup();

            joke.Lang = "fr";

            Assert.Equal("fr", joke.Lang);
        }
        #endregion
    }
}