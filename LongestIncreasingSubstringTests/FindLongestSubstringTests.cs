using LongestIncreasingSubstring.Manager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubstringTests
{
    [TestClass]
    public class FindLongestSubstringTests
    {
        private FindLongestSubstringManager manager;

        [TestInitialize]
        public void Setup()
        {
            manager = new FindLongestSubstringManager();
        }

        [TestMethod]
        public void GetLongestSubstring_ValidShortString_ReturnsExpectedSubstring()
        {
            var input = "6 1 5 9 2";

            var result = manager.GetLongestSubstring(input);
            var expectedResult = new List<int> { 1, 5, 9 };
            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void GetLongestSubstring_ValidLongString_ReturnsExpectedSubstring()
        {
            var input = "31278 18525 32621 9940 30345 29338 17925 6490 2380 17298 24221 14169 22842 12875 25133 31675 25635 14755 17195 9706 26458 28402 6563 9619 11369 27627 30090 29610 3586 4035 11088 31918 18745 23446 20148 46 28401 28166 20444 2444 2452 25125 28325 26113 19208 5525 30776 15329 22238 6637 734 10016 31948 21855 7189 32534 30557 5784 7395 10623 743 8168 6250 7878 24766 28067 6333 899 6823 15303 7666 31554 6799 3806 4984 6278 27261 17446 12203 3597 12486 27888 29094 1366 15488 31046 12632 15969 13880 30160 30171 23734 18664 24825 1536 1448 22307 23373 26415 13275 4243 14117 15982 25604 31653 11143 18367 32496 18307 11848 22447 9416 31299 14707 6956 15763 20317 32751 2455 29436 23139 21851 15642 30549 16876 19773 9532 15837 9938 21852 18354 2110 2973 20330 888 27994 20542 28134 2593 15687 5633 22593 876 26264 8125 23104 3863 16607 589 8865 6392 24688 14660 21761 13129 22375 29661 29437 27460 2028 11825 24728 19440 27573 27309 2012 826 29901 8130 24517 23879 27540 11742 23130 2569 28168 29084 32285 24848 29762 17976 11941 6051 32323 3141 26762 7440 20209 2210 29825 4416 22621 12202 21960 2446 15687 12459 30661 6105 3044 21913 24298 18392 5599 2820 24795 1710 2461 9288 10195 10431 12485 12292 1348 449 30720 28877 22461 17174 9213 20003 2065 5209 22457 20899 25014 6711 20477 1151 19051 24448 30760 16684 7453 21629 15406 19802 11276 22661 15329 20521 11818 459 17263 30874 7107 6010 11564 26691 15971 29188 4242 13896 30709 13750 25222 7814 1320 7057 27357 12561 16151 15445 13087 5601 8232 4574 21131 14536 4148 8883 15195 29095 15337 3037 27977 31970 31597 23797 12625 22545 3140 31361 17081 22265 8820 31361 2383 1210 5351 12100 18674 9545 10512 21632 27219 27425 16850 4770 16637 13622 30109 19555 29331 26923 20442 27292 25433 15812 16777 6747 19446 2462 1320 12598 23673 27166 31191 11231 4249 22183 14779 31481 6465 29712 28576 4650 32588 15445 12258 28018 25485 20108 22669 187 18 31515 15555 17841 20137 24617 8030 23507 30884 10834 16599 28362 29658 19871 1127 22266 28910 19125 28779 10328 32468 21580 3597 9083 1936 26851 27681 15605 2625 13490 18765 12003";

            var result = manager.GetLongestSubstring(input);
            var expectedResult = new List<int> { 1710, 2461, 9288, 10195, 10431, 12485 };
            Assert.IsTrue(result.SequenceEqual(expectedResult));
        }

        [TestMethod]
        public void GetLongestSubstring_MixedCharAndNumbersInput_ReturnsExpectedSubstring()
        {
            var input = "@@345 #$555 1111 sdsf gggg 7%^%9 9999";

            var result = manager.GetLongestSubstring(input);
            Assert.IsTrue(result.SequenceEqual(new List<int> { 1111, 9999 }));
        }

        [TestMethod]
        public void GetLongestSubstring_SpecialCharactersInput_ReturnsEmptyResult()
        {
            var input = "@@#@ #$55 sdsf gggg 7%^%9";

            var result = manager.GetLongestSubstring(input);
            Assert.IsTrue(result.SequenceEqual(new List<int>()));
        }

        [TestMethod]
        public void GetLongestSubstring_EmptyInput_ReturnsEmptyResult()
        {
            var input = "";

            var result = manager.GetLongestSubstring(input);
            Assert.IsTrue(result.SequenceEqual(new List<int>()));
        }
    }
}
