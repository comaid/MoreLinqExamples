using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoreLinq;
using MoreLinq.Experimental;

namespace MoreLinqSamples
{
    [TestClass]
    public class MoreLinqTest
    {
        [TestMethod]
        public void AcquireTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AggregateTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AggregateRightTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AppendTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AssertTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AssertCountTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AtLeastTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void AtMostTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void BacksertTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void BatchTest()
        {
            // シーケンスにしてされた数ごとにまとめる
            // (0,1,2,3,4,5) => Batch(3) => ((0,1,2),(3,4,5))

            var sequence = Enumerable.Range(0, 6);

            var morelinq = sequence.Batch(3);

            var linq = sequence.Select((Value, Index) => new { Value, Index }).GroupBy(i => i.Index / 3).Select(i => i.Select(j => j.Value));

            Assert.AreEqual(morelinq.Count(), linq.Count());
            Assert.IsTrue(morelinq.ElementAt(0).SequenceEqual(linq.ElementAt(0)));
            Assert.IsTrue(morelinq.ElementAt(1).SequenceEqual(linq.ElementAt(1)));
        }


        [TestMethod]
        public void CartesianTest()
        {
            // 直積を作る
            // (0,1,2)x(0,1) => ((0,0),(0,1),(1,0),(1,1),(2,0),(2,1))

            var first = Enumerable.Range(0, 3);
            var second = Enumerable.Range(0, 2);

            var morelinq = first.Cartesian(second, (f, s) => (f, s));

            var linq = from f in first
                       from s in second
                       select (f, s);

            Assert.IsTrue(morelinq.SequenceEqual(linq));
        }


        [TestMethod]
        public void ChooseTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void CompareCountTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ConsumeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void CountBetweenTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void CountByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void CountDownTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void DistinctByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void EndsWithTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void EquiZipTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ExactlyTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ExceptByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ExcludeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FallbackIfEmptyTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FillBackwardTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FillForwardTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FlattenTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FoldTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ForEachTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FromTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FullGroupJoinTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void FullJoinTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void GenerateTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void GenerateByIndexTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void GroupAdjacentTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void MyTestMethod()
        {
            Assert.IsFalse((new KeyValuePair<int, string>(1, "FOO")).Equals(new KeyValuePair<int, string>(2, "FOO")));
            Assert.IsTrue((new KeyValuePair<int, string>(1, "FOO")).Equals(new KeyValuePair<int, string>(1, "FOO")));
            Assert.IsFalse((new KeyValuePair<int, string>(1, "FOO")).Equals(new KeyValuePair<int, string>(1, "FOX")));
        }


        [TestMethod]
        public void IndexTest()
        {
            //シーケンスに連番を与える。 Selec((value, index) => ...)と同等

              var sequence = new[] { "foo", "bar", "baz" };

            var morelinq = sequence.Index();

            var linq = sequence.Select((value, key) => new KeyValuePair<int, string>(key, value));

            Assert.IsTrue(morelinq.SequenceEqual(linq));
        }


        [TestMethod]
        public void IndexByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void InsertTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void InterleaveTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void LagTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void LeadTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void LeftJoinTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void MaxByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void MinByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void MoveTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void OrderByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void OrderedMergeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PadTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PadStartTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PairwiseTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PartialSortTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PartialSortByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PartitionTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PermutationsTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PipeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PrependTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void PreScanTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RandomTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RandomDoubleTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RandomSubsetTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RankTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RankByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RepeatTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ReturnTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RightJoinTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void RunLengthEncodeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ScanTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ScanByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ScanRightTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SegmentTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SequenceTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ShuffleTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SkipLastTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SkipUntilTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SliceTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SortedMergeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SplitTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void StartsWithTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void SubsetsTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TagFirstLastTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TakeEveryTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TakeLastTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TakeUntilTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ThenByTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToArrayByIndexTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToDataTableTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToDelimitedStringTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToDictionaryTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToHashSetTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ToLookupTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TransposeTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TraverseBreadthFirstTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TraverseDepthFirstTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TraceTest()
        {
            //シーケンス内容を Trace.WriteLine() を使って出力する。
            // (ToArray()をつけているのは評価されないと実行されないから)
            Enumerable.Range(0, 3).Trace().ToArray();

             //↑と等価。
            foreach (var i in Enumerable.Range(0, 3))
            {
                Trace.WriteLine(i);
            }

            //書式指定もできる
            Enumerable.Range(3, 3).Trace(i => $"{i:X02}").ToArray();
        }


        [TestMethod]
        public void TrySingleTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void UnfoldTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void WindowTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void WindowLeftTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void WindowRightTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ZipLongestTest()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void ZipShortestTest()
        {
            throw new NotImplementedException();
        }

    }
}
