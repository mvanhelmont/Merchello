﻿namespace Merchello.Core.Marketing.Constraints
{
    using Merchello.Core.Marketing.Discounts;
    using Merchello.Core.Marketing.Offer;
    using Merchello.Core.Models;

    using Umbraco.Core;

    /// <summary>
    /// A discount validation constraint to restrict this offer to line item price related rules.
    /// </summary>
    [OfferComponent("66957C56-8A5E-4ECD-BDEB-565F8777A38F", "Restrict by price", "This discount is only offered matching configured price rules.",
        "~/App_Plugins/Merchello/Backoffice/Merchello/Dialogs/marketing.offerconstraint.price.html")]
    public class OfferPriceConstraint : OfferConstraintComponentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferPriceConstraint"/> class.
        /// </summary>
        /// <param name="definition">
        /// The definition.
        /// </param>
        public OfferPriceConstraint(OfferComponentDefinition definition)
            : base(definition)
        {
        }

        public override Attempt<ILineItemContainer> Validate(ICustomerBase customer, ILineItemContainer collection)
        {
            throw new System.NotImplementedException();
        }
    }
}