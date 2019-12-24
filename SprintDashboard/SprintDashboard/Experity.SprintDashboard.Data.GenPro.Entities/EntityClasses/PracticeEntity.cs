﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Runtime.Serialization;
using Experity.SprintDashboard.Data.GenPro.Entities.FactoryClasses;
using Experity.SprintDashboard.Data.GenPro.Entities.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Experity.SprintDashboard.Data.GenPro.Entities.EntityClasses
{
    // __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
    // __LLBLGENPRO_USER_CODE_REGION_END

    /// <summary>Entity class which represents the entity 'Practice'.<br/><br/></summary>
    [Serializable]
    public partial class PracticeEntity : CommonEntityBase
    // __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
    // __LLBLGENPRO_USER_CODE_REGION_END

    {
        private EntityCollection<ClinicEntity> _clinics;
        // __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
        // __LLBLGENPRO_USER_CODE_REGION_END

        private static PracticeEntityStaticMetaData _staticMetaData = new PracticeEntityStaticMetaData();
        private static PracticeRelations _relationsFactory = new PracticeRelations();

        /// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
        public static partial class MemberNames
        {
            /// <summary>Member name Clinics</summary>
            public static readonly string Clinics = "Clinics";
            /// <summary>Member name Conversations</summary>
            public static readonly string Conversations = "Conversations";
            /// <summary>Member name SubjectLookups</summary>
            public static readonly string SubjectLookups = "SubjectLookups";
            /// <summary>Member name UserProfiles</summary>
            public static readonly string UserProfiles = "UserProfiles";
        }

        /// <summary>Static meta-data storage for navigator related information</summary>
        protected class PracticeEntityStaticMetaData : EntityStaticMetaDataBase
        {
            public PracticeEntityStaticMetaData()
            {
                SetEntityCoreInfo("PracticeEntity", InheritanceHierarchyType.None, false, (int)EntityType.PracticeEntity, typeof(PracticeEntity), typeof(PracticeEntityFactory), false);
                AddNavigatorMetaData<PracticeEntity, EntityCollection<ClinicEntity>>("Clinics", a => a._clinics, (a, b) => a._clinics = b, a => a.Clinics, () => new PracticeRelations().ClinicEntityUsingPracticePk, typeof(ClinicEntity), (int)EntityType.ClinicEntity);
            }
        }

        /// <summary>Static ctor</summary>
        static PracticeEntity()
        {
        }

        /// <summary> CTor</summary>
        public PracticeEntity()
        {
            InitClassEmpty(null, null);
        }

        /// <summary> CTor</summary>
        /// <param name="fields">Fields object to set as the fields for this entity.</param>
        public PracticeEntity(IEntityFields2 fields)
        {
            InitClassEmpty(null, fields);
        }

        /// <summary> CTor</summary>
        /// <param name="validator">The custom validator object for this PracticeEntity</param>
        public PracticeEntity(IValidator validator)
        {
            InitClassEmpty(validator, null);
        }

        /// <summary> CTor</summary>
        /// <param name="practicePk">PK value for Practice which data should be fetched into this Practice object</param>
        public PracticeEntity(System.Guid practicePk) : this(practicePk, null)
        {
        }

        /// <summary> CTor</summary>
        /// <param name="practicePk">PK value for Practice which data should be fetched into this Practice object</param>
        /// <param name="validator">The custom validator object for this PracticeEntity</param>
        public PracticeEntity(System.Guid practicePk, IValidator validator)
        {
            InitClassEmpty(validator, null);
            this.PracticePk = practicePk;
        }

        /// <summary>Private CTor for deserialization</summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected PracticeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            // __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
            // __LLBLGENPRO_USER_CODE_REGION_END
        }

        /// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Clinic' to this entity.</summary>
        /// <returns></returns>
        public virtual IRelationPredicateBucket GetRelationInfoClinics() { return CreateRelationInfoForNavigator("Clinics"); }

        /// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Conversation' to this entity.</summary>
        /// <returns></returns>
        public virtual IRelationPredicateBucket GetRelationInfoConversations() { return CreateRelationInfoForNavigator("Conversations"); }

        /// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SubjectLookup' to this entity.</summary>
        /// <returns></returns>
        public virtual IRelationPredicateBucket GetRelationInfoSubjectLookups() { return CreateRelationInfoForNavigator("SubjectLookups"); }

        /// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UserProfile' to this entity.</summary>
        /// <returns></returns>
        public virtual IRelationPredicateBucket GetRelationInfoUserProfiles() { return CreateRelationInfoForNavigator("UserProfiles"); }

        /// <inheritdoc/>
        protected override EntityStaticMetaDataBase GetEntityStaticMetaData() { return _staticMetaData; }

        /// <summary>Initializes the class members</summary>
        private void InitClassMembers()
        {
            PerformDependencyInjection();
            // __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
            // __LLBLGENPRO_USER_CODE_REGION_END

            OnInitClassMembersComplete();
        }

        /// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
        /// <param name="validator">The validator object for this PracticeEntity</param>
        /// <param name="fields">Fields of this entity</param>
        private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
        {
            OnInitializing();
            this.Fields = fields ?? CreateFields();
            this.Validator = validator;
            InitClassMembers();
            // __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
            // __LLBLGENPRO_USER_CODE_REGION_END


            OnInitialized();
        }

        /// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
        public static PracticeRelations Relations { get { return _relationsFactory; } }

        /// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Clinic' for this entity.</summary>
        /// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
        public static IPrefetchPathElement2 PrefetchPathClinics { get { return _staticMetaData.GetPrefetchPathElement("Clinics", CommonEntityBase.CreateEntityCollection<ClinicEntity>()); } }

        public virtual System.String Environment
        {
            get { return (System.String)GetValue((int)PracticeFieldIndex.Environment, true); }
            set { SetValue((int)PracticeFieldIndex.Environment, value); }
        }

        /// <summary>The Practice property of the Entity Practice<br/><br/></summary>
        /// <remarks>Mapped on  table field: "Practice"."Practice".<br/>Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 5.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
        public virtual System.String Practice
        {
            get { return (System.String)GetValue((int)PracticeFieldIndex.Practice, true); }
            set { SetValue((int)PracticeFieldIndex.Practice, value); }
        }

        /// <summary>The PracticePk property of the Entity Practice<br/><br/></summary>
        /// <remarks>Mapped on  table field: "Practice"."PracticePk".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
        public virtual System.Guid PracticePk
        {
            get { return (System.Guid)GetValue((int)PracticeFieldIndex.PracticePk, true); }
            set { SetValue((int)PracticeFieldIndex.PracticePk, value); }
        }

        /// <summary>Gets the EntityCollection with the related entities of type 'ClinicEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
        [TypeContained(typeof(ClinicEntity))]
        public virtual EntityCollection<ClinicEntity> Clinics { get { return GetOrCreateEntityCollection<ClinicEntity, ClinicEntityFactory>("Practice", true, false, ref _clinics); } }

    }

    public enum PracticeFieldIndex
    {
        ///<summary>Environment. </summary>
        Environment,
        ///<summary>Practice. </summary>
        Practice,
        ///<summary>PracticePk. </summary>
        PracticePk,
        /// <summary></summary>
        AmountOfFields
    }

    /// <summary>Implements the relations factory for the entity: Practice. </summary>
    public partial class PracticeRelations : RelationFactory
    {
        /// <summary>Returns a new IEntityRelation object, between PracticeEntity and ClinicEntity over the 1:n relation they have, using the relation between the fields: Practice.PracticePk - Clinic.PracticePk</summary>
        public virtual IEntityRelation ClinicEntityUsingPracticePk
        {
            get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Clinics", true, new[] { PracticeFields.PracticePk, ClinicFields.PracticePk }); }
        }

    }

    /// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
    internal static class StaticPracticeRelations
    {
        internal static readonly IEntityRelation ClinicEntityUsingPracticePkStatic = new PracticeRelations().ClinicEntityUsingPracticePk;

        /// <summary>CTor</summary>
        static StaticPracticeRelations() { }
    }
}