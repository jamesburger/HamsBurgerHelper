using System;

namespace HamsBurgerHelper.Common
{
    /// <summary>
    /// Represents a rule that might be associated with an army or a unit.
    /// </summary>
    public class Rule
    {
        /// <summary>
        /// Gets or sets a string representation a given <see cref="Rule"/> name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique Guid Id.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the text representing the <see cref="Rule"/> text.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the enum representing when a <see cref="Rule"/> is activated during the turn.
        /// </summary>
        public TurnPhases ActivationPhase { get; set; } = TurnPhases.None;
    }
}