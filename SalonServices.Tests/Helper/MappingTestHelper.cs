using SalonServices.Mappings;
using System;
using System.Collections.Generic;
using System.Text;
using GenFu;
using FluentAssertions;
using FluentAssertions.Equivalency;

namespace SalonServices.Tests.Helper
{
    public static class MappingTestHelpers
    {
        public static void MapFromModelAndBack<TModel, TEntity>(Func<TModel, TEntity, TEntity> pEntitySetup = null, Func<EquivalencyAssertionOptions<TModel>, EquivalencyAssertionOptions<TModel>> pConfig = null) where TModel : new()
        {
            // Arrange
            var lModel = A.New<TModel>();

            // Act
            var lEntity = Mapping.Mapper.Map<TEntity>(lModel);
            if (pEntitySetup != null)
            {
                lEntity = pEntitySetup(lModel, lEntity);
            }

            var lResult = Mapping.Mapper.Map<TModel>(lEntity);

            // Assert
            if (pConfig == null)
            {
                lModel.ShouldBeEquivalentTo(lResult);
            }
            else
            {
                lModel.ShouldBeEquivalentTo(lResult, pConfig);
            }
        }

    }
    

}
