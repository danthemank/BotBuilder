﻿using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Bot.Builder.Form.Advanced
{
    public enum SpecialValues { Field };

    public class TermMatch
    {
        public TermMatch(int start, int length, double confidence, object value)
        {
            Start = start;
            Length = length;
            Confidence = confidence;
            Value = value;
        }

        public readonly object Value;
        public readonly double Confidence;
        public readonly int Start;
        public int End { get { return Start + Length; } }
        public readonly int Length;

        /// <summary>
        /// Check to see if this covers the same span as match.
        /// </summary>
        /// <param name="match">TermMatch to compare.</param>
        /// <returns>True if both cover the same span.</returns>
        public bool Same(TermMatch match)
        {
            return Start == match.Start && End == match.End;
        }

        /// <summary>
        /// Check to see if this completely covers match.
        /// </summary>
        /// <param name="match"></param>
        /// <returns>True if this covers all of match.</returns>
        public bool Covers(TermMatch match)
        {
            return Start <= match.Start && End >= match.End && (Start != match.Start || End != match.End);
        }

        /// <summary>
        /// Check to see if this overlaps with match.
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public bool Overlaps(TermMatch match)
        {
            return (match.Start <= End && Start <= match.Start && End <= match.End) // tmtm
                || (Start <= match.End && match.Start <= Start && match.End <= End) // mtmt
                || (Start <= match.Start && End >= match.End) // tmmt
                || (match.Start <= Start && match.End >= End) // mttm
                ;
        }

        public override string ToString()
        {
            return string.Format("TermMatch({0}, {1}, {2}-{3})", Value, Confidence, Start, Start + Length);
        }

        public override bool Equals(object obj)
        {
            return obj is TermMatch && this == (TermMatch)obj;
        }

        public static bool operator ==(TermMatch m1, TermMatch m2)
        {
            return ReferenceEquals(m1, m2) || (!ReferenceEquals(m1, null) && !ReferenceEquals(m2, null) && m1.Start == m2.Start && m1.Length == m2.Length && m1.Confidence == m2.Confidence && m1.Value == m2.Value);
        }

        public static bool operator !=(TermMatch m1, TermMatch m2)
        {
            return !(m1 == m2);
        }

        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ Length.GetHashCode() ^ Confidence.GetHashCode() ^ Value.GetHashCode();
        }
    }

    public interface IRecognizer
    {
        /// <summary>
        /// Return all possible values or null if a primitive type.
        /// </summary>
        /// <returns>All possible values.</returns>
        IEnumerable<object> Values();

        /// <summary>
        /// Return all possible value descriptions in order to support enumeration.
        /// </summary>
        /// <returns>All possible value descriptions.</returns>
        IEnumerable<string> ValueDescriptions();

        /// <summary>
        /// Return the description of a specific value.
        /// </summary>
        /// <param name="value">Value to get description of.</param>
        /// <returns></returns>
        string ValueDescription(object value);

        /// <summary>
        /// Return valid inputs to describe a particular value.
        /// </summary>
        /// <param name="value">Value being checked.</param>
        /// <returns>Valid inputs for describing value.</returns>
        IEnumerable<string> ValidInputs(object value);

        /// <summary>
        /// Return the help string describing what are valid inputs to the recognizer.
        /// </summary>
        /// <returns>Help on what the recognizer accepts.</returns>
        string Help(object defaultValue = null);

        /// <summary>
        /// Return the matches found in the input.
        /// </summary>
        /// <param name="input">The input string being matched.</param>
        /// <param name="defaultValue">The default value or null if none.</param>
        /// <returns>Match records.</returns>
        IEnumerable<TermMatch> Matches(string input, object defaultValue = null);
    }
 }