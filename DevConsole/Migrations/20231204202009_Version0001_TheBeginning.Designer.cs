﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Navislamia.Database.Contexts;
using Navislamia.Game.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DevConsole.Migrations
{
    [DbContext(typeof(ArcadiaContext))]
    [Migration("20231204202009_Version0001_TheBeginning")]
    partial class Version0001_TheBeginning
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DevConsole.Models.Arcadia.ChannelResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Bottom")
                        .HasColumnType("integer");

                    b.Property<int>("ChannelType")
                        .HasColumnType("integer");

                    b.Property<int>("Left")
                        .HasColumnType("integer");

                    b.Property<int>("Right")
                        .HasColumnType("integer");

                    b.Property<int>("Top")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ChannelResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.EffectResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EffectResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.EnhanceResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EnhanceType")
                        .HasColumnType("integer");

                    b.Property<int>("FailResult")
                        .HasColumnType("integer");

                    b.Property<int>("LocalFlag")
                        .HasColumnType("integer");

                    b.Property<short>("MaxEnhance")
                        .HasColumnType("smallint");

                    b.Property<int>("NeedItem")
                        .HasColumnType("integer");

                    b.Property<decimal[]>("Percentage")
                        .HasMaxLength(20)
                        .HasPrecision(10, 3)
                        .HasColumnType("numeric[]");

                    b.HasKey("Id");

                    b.ToTable("EnhanceResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.GlobalVariableEntity", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("GlobalVariables");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.ItemEffectResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<short>("EffectId")
                        .HasColumnType("smallint");

                    b.Property<short>("EffectLevel")
                        .HasColumnType("smallint");

                    b.Property<int>("EffectType")
                        .HasColumnType("integer");

                    b.Property<int>("OrdinalId")
                        .HasColumnType("integer");

                    b.Property<int>("TooltipId")
                        .HasColumnType("integer");

                    b.Property<int[]>("Value")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("ItemEffectResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.ItemResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailablePeriod")
                        .HasColumnType("integer");

                    b.Property<int[]>("BaseType")
                        .HasMaxLength(2)
                        .HasColumnType("integer[]");

                    b.Property<decimal[,]>("BaseVar")
                        .HasMaxLength(8)
                        .HasPrecision(12, 2)
                        .HasColumnType("numeric[]");

                    b.Property<short>("ClassRestriction")
                        .HasColumnType("smallint");

                    b.Property<int>("CoolTime")
                        .HasColumnType("integer");

                    b.Property<short>("CoolTimeGroup")
                        .HasColumnType("smallint");

                    b.Property<int>("DecreaseType")
                        .HasColumnType("integer");

                    b.Property<int>("EffectId")
                        .HasColumnType("integer");

                    b.Property<int[]>("EnchanceId")
                        .HasMaxLength(2)
                        .HasColumnType("integer[]");

                    b.Property<decimal[,]>("EnchanceVar")
                        .HasMaxLength(8)
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric[]");

                    b.Property<int>("Endurance")
                        .HasColumnType("integer");

                    b.Property<int>("Enhance")
                        .HasColumnType("integer");

                    b.Property<int>("EtherealDurability")
                        .HasColumnType("integer");

                    b.Property<int>("Grade")
                        .HasColumnType("integer");

                    b.Property<int>("Group")
                        .HasColumnType("integer");

                    b.Property<int>("HuntaholicPoint")
                        .HasColumnType("integer");

                    b.Property<int>("ItemBaseType")
                        .HasColumnType("integer");

                    b.Property<int>("ItemType")
                        .HasColumnType("integer");

                    b.Property<int>("ItemUseFlag")
                        .HasColumnType("integer");

                    b.Property<short>("JobDepth")
                        .HasColumnType("smallint");

                    b.Property<short>("JobRestriction")
                        .HasColumnType("smallint");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("Material")
                        .HasColumnType("integer");

                    b.Property<int>("NameId")
                        .HasColumnType("integer");

                    b.Property<int[]>("OptType")
                        .HasMaxLength(2)
                        .HasColumnType("integer[]");

                    b.Property<decimal[,]>("OptVar")
                        .HasMaxLength(8)
                        .HasPrecision(12, 2)
                        .HasColumnType("numeric[]");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<decimal>("Range")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("Rank")
                        .HasColumnType("integer");

                    b.Property<string>("ScriptText")
                        .HasColumnType("text");

                    b.Property<int>("SetId")
                        .HasColumnType("integer");

                    b.Property<int>("SetPartFlag")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.Property<int>("SocketCount")
                        .HasColumnType("integer");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.Property<int>("StateLevel")
                        .HasColumnType("integer");

                    b.Property<int>("StateTime")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("SummonId")
                        .HasColumnType("integer");

                    b.Property<int>("TargetMaxLevel")
                        .HasColumnType("integer");

                    b.Property<int>("TargetMinLevel")
                        .HasColumnType("integer");

                    b.Property<decimal>("ThrowRange")
                        .HasColumnType("numeric");

                    b.Property<int>("TooltipId")
                        .HasColumnType("integer");

                    b.Property<int>("UseMaxLevel")
                        .HasColumnType("integer");

                    b.Property<int>("UseMinLevel")
                        .HasColumnType("integer");

                    b.Property<int>("WearType")
                        .HasColumnType("integer");

                    b.Property<decimal>("Weight")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.HasKey("Id");

                    b.ToTable("ItemResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.LevelResourceEntity", b =>
                {
                    b.Property<int>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Level"));

                    b.Property<int[]>("Jl")
                        .HasColumnType("integer[]");

                    b.Property<long>("NormalExp")
                        .HasColumnType("bigint");

                    b.HasKey("Level");

                    b.ToTable("LevelResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.SetItemEffectResourceEntity", b =>
                {
                    b.Property<int>("SetId")
                        .HasColumnType("integer");

                    b.Property<short>("SetParts")
                        .HasColumnType("smallint");

                    b.Property<int[]>("BaseType")
                        .HasColumnType("integer[]");

                    b.Property<decimal[,]>("BaseVar")
                        .HasColumnType("numeric[]");

                    b.Property<int>("EffectId")
                        .HasColumnType("integer");

                    b.Property<int[]>("OptType")
                        .HasColumnType("integer[]");

                    b.Property<decimal[,]>("OptVar")
                        .HasColumnType("numeric[]");

                    b.Property<int>("TextId")
                        .HasColumnType("integer");

                    b.Property<int>("TooltipId")
                        .HasColumnType("integer");

                    b.HasKey("SetId", "SetParts");

                    b.ToTable("SetItemEffectResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.SkillResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CastRange")
                        .HasColumnType("integer");

                    b.Property<string>("CastingLevel")
                        .HasColumnType("text");

                    b.Property<string>("CastingType")
                        .HasColumnType("text");

                    b.Property<int>("CoolTimeGroupId")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostEnergy")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("CostEnergyPerSkl")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("CostExp")
                        .HasColumnType("integer");

                    b.Property<int>("CostExpPerEnhance")
                        .HasColumnType("integer");

                    b.Property<int>("CostHavoc")
                        .HasColumnType("integer");

                    b.Property<int>("CostHavocPerSkl")
                        .HasColumnType("integer");

                    b.Property<int>("CostHp")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostHpPer")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("CostHpPerSkl")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostHpPerSklPer")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("CostItem")
                        .HasColumnType("integer");

                    b.Property<int>("CostItemCount")
                        .HasColumnType("integer");

                    b.Property<int>("CostItemCountPerSkl")
                        .HasColumnType("integer");

                    b.Property<int>("CostJp")
                        .HasColumnType("integer");

                    b.Property<int>("CostJpPerEnhance")
                        .HasColumnType("integer");

                    b.Property<int>("CostMp")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostMpPer")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("CostMpPerEnhance")
                        .HasColumnType("integer");

                    b.Property<int>("CostMpPerSkl")
                        .HasColumnType("integer");

                    b.Property<decimal>("CostMpPerSklPer")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("CriticalBonus")
                        .HasColumnType("integer");

                    b.Property<int>("CriticalBonusPerSkl")
                        .HasColumnType("integer");

                    b.Property<decimal>("DelayCast")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCastModePerEnhance")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCastPerSkl")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCommon")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCooltime")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCooltimeModePerEnhance")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("DelayCooltimePerSkl")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("DescId")
                        .HasColumnType("integer");

                    b.Property<int>("EffectType")
                        .HasColumnType("integer");

                    b.Property<string>("Elemental")
                        .HasColumnType("text");

                    b.Property<short>("HateBasic")
                        .HasColumnType("smallint");

                    b.Property<decimal>("HateMod")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("HatePerEnhance")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("HatePerSkill")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<short>("HitBonus")
                        .HasColumnType("smallint");

                    b.Property<short>("HitBonusPerEnhance")
                        .HasColumnType("smallint");

                    b.Property<string>("IconFileName")
                        .HasColumnType("text");

                    b.Property<int>("IconId")
                        .HasColumnType("integer");

                    b.Property<string>("IsCorpse")
                        .HasColumnType("text");

                    b.Property<string>("IsHarmful")
                        .HasColumnType("text");

                    b.Property<string>("IsNeedTarget")
                        .HasColumnType("text");

                    b.Property<string>("IsPassive")
                        .HasColumnType("text");

                    b.Property<string>("IsPhysicalAct")
                        .HasColumnType("text");

                    b.Property<string>("IsToggle")
                        .HasColumnType("text");

                    b.Property<int>("NeedHavoc")
                        .HasColumnType("integer");

                    b.Property<int>("NeedHavocBurst")
                        .HasColumnType("integer");

                    b.Property<int>("NeedHp")
                        .HasColumnType("integer");

                    b.Property<int>("NeedLevel")
                        .HasColumnType("integer");

                    b.Property<int>("NeedMp")
                        .HasColumnType("integer");

                    b.Property<int>("NeedStateId")
                        .HasColumnType("integer");

                    b.Property<short>("Percentage")
                        .HasColumnType("smallint");

                    b.Property<int>("ProbabilityIncBySlv")
                        .HasColumnType("integer");

                    b.Property<int>("ProbabilityOnHit")
                        .HasColumnType("integer");

                    b.Property<decimal>("ProjectileAcceleration")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("ProjectileSpeed")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("SkillEnchantLinkId")
                        .HasColumnType("integer");

                    b.Property<string>("SkillLvupLimit")
                        .HasColumnType("text");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.Property<int>("StateLevelBase")
                        .HasColumnType("integer");

                    b.Property<decimal>("StateLevelPerEnhance")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("StateLevelPerSkl")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("StateSecond")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("StateSecondPerEnhance")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<decimal>("StateSecondPerLevel")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("Target")
                        .HasColumnType("integer");

                    b.Property<int>("TextId")
                        .HasColumnType("integer");

                    b.Property<string>("TfAvatar")
                        .HasColumnType("text");

                    b.Property<string>("TfMonster")
                        .HasColumnType("text");

                    b.Property<string>("TfSummon")
                        .HasColumnType("text");

                    b.Property<int>("ToggleGroup")
                        .HasColumnType("integer");

                    b.Property<int>("TooltipId")
                        .HasColumnType("integer");

                    b.Property<string>("UfEnemy")
                        .HasColumnType("text");

                    b.Property<string>("UfGuild")
                        .HasColumnType("text");

                    b.Property<string>("UfNeutral")
                        .HasColumnType("text");

                    b.Property<string>("UfParty")
                        .HasColumnType("text");

                    b.Property<string>("UfPurple")
                        .HasColumnType("text");

                    b.Property<string>("UfSelf")
                        .HasColumnType("text");

                    b.Property<int>("ValidRange")
                        .HasColumnType("integer");

                    b.Property<decimal[]>("Var")
                        .HasMaxLength(19)
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric[]");

                    b.Property<string>("VfAxe")
                        .HasColumnType("text");

                    b.Property<string>("VfCrossbow")
                        .HasColumnType("text");

                    b.Property<string>("VfDagger")
                        .HasColumnType("text");

                    b.Property<string>("VfDoubleAxe")
                        .HasColumnType("text");

                    b.Property<string>("VfDoubleDagger")
                        .HasColumnType("text");

                    b.Property<string>("VfDoubleSword")
                        .HasColumnType("text");

                    b.Property<string>("VfHeavybow")
                        .HasColumnType("text");

                    b.Property<string>("VfIsNotNeedWeapon")
                        .HasColumnType("text");

                    b.Property<string>("VfLightbow")
                        .HasColumnType("text");

                    b.Property<string>("VfOneHandAxe")
                        .HasColumnType("text");

                    b.Property<string>("VfOneHandMace")
                        .HasColumnType("text");

                    b.Property<string>("VfOneHandStaff")
                        .HasColumnType("text");

                    b.Property<string>("VfOneHandSword")
                        .HasColumnType("text");

                    b.Property<string>("VfShieldOnly")
                        .HasColumnType("text");

                    b.Property<string>("VfSpear")
                        .HasColumnType("text");

                    b.Property<string>("VfTwoHandMace")
                        .HasColumnType("text");

                    b.Property<string>("VfTwoHandStaff")
                        .HasColumnType("text");

                    b.Property<string>("VfTwoHandSword")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SkillResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.StatResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Agi")
                        .HasColumnType("integer");

                    b.Property<int>("Dex")
                        .HasColumnType("integer");

                    b.Property<int>("Int")
                        .HasColumnType("integer");

                    b.Property<int>("Luk")
                        .HasColumnType("integer");

                    b.Property<int>("Men")
                        .HasColumnType("integer");

                    b.Property<int>("Str")
                        .HasColumnType("integer");

                    b.Property<int>("Vit")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("StatResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.StateResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddDamageBase")
                        .HasColumnType("integer");

                    b.Property<int>("AddDamagePerSkl")
                        .HasColumnType("integer");

                    b.Property<decimal>("AmplifyBase")
                        .HasPrecision(13, 3)
                        .HasColumnType("numeric(13,3)");

                    b.Property<decimal>("AmplifyPerSkill")
                        .HasPrecision(13, 3)
                        .HasColumnType("numeric(13,3)");

                    b.Property<int>("BaseEffect")
                        .HasColumnType("integer");

                    b.Property<int>("CastFxId")
                        .HasColumnType("integer");

                    b.Property<int>("CastFxPosId")
                        .HasColumnType("integer");

                    b.Property<int>("CastSkillId")
                        .HasColumnType("integer");

                    b.Property<int[]>("DuplicateGroup")
                        .HasMaxLength(3)
                        .HasColumnType("integer[]");

                    b.Property<int>("EffectType")
                        .HasColumnType("integer");

                    b.Property<int>("ElementalType")
                        .HasColumnType("integer");

                    b.Property<int>("FireInterval")
                        .HasColumnType("integer");

                    b.Property<int>("FxId")
                        .HasColumnType("integer");

                    b.Property<int>("HitFxId")
                        .HasColumnType("integer");

                    b.Property<int>("HitFxPosId")
                        .HasColumnType("integer");

                    b.Property<string>("IconFileName")
                        .HasColumnType("text");

                    b.Property<int>("IconId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsHarmful")
                        .HasColumnType("boolean");

                    b.Property<int>("PosId")
                        .HasColumnType("integer");

                    b.Property<string>("ReiterationCount")
                        .HasColumnType("text");

                    b.Property<int>("SpecialOutputFxDelay")
                        .HasColumnType("integer");

                    b.Property<int>("SpecialOutputFxId")
                        .HasColumnType("integer");

                    b.Property<int>("SpecialOutputFxPosId")
                        .HasColumnType("integer");

                    b.Property<int>("SpecialOutputTimingId")
                        .HasColumnType("integer");

                    b.Property<int>("StateFxId")
                        .HasColumnType("integer");

                    b.Property<int>("StateFxPosId")
                        .HasColumnType("integer");

                    b.Property<int>("StateGroup")
                        .HasColumnType("integer");

                    b.Property<short>("StateTimeType")
                        .HasColumnType("smallint");

                    b.Property<int>("TextId")
                        .HasColumnType("integer");

                    b.Property<int>("TooltipId")
                        .HasColumnType("integer");

                    b.Property<string>("UfAvatar")
                        .HasColumnType("text");

                    b.Property<string>("UfMonster")
                        .HasColumnType("text");

                    b.Property<string>("UfSummon")
                        .HasColumnType("text");

                    b.Property<int[]>("Value")
                        .HasMaxLength(20)
                        .HasPrecision(13, 3)
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("StateResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.StringResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("StringResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.SummonResourceEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AttackMotionSpeed")
                        .HasColumnType("integer");

                    b.Property<decimal>("AttackRange")
                        .HasColumnType("numeric");

                    b.Property<int>("CameraX")
                        .HasColumnType("integer");

                    b.Property<int>("CameraY")
                        .HasColumnType("integer");

                    b.Property<int>("CameraZ")
                        .HasColumnType("integer");

                    b.Property<int>("CardId")
                        .HasColumnType("integer");

                    b.Property<int>("EvolutionStage")
                        .HasColumnType("integer");

                    b.Property<int>("EvolveTargetId")
                        .HasColumnType("integer");

                    b.Property<string>("FaceFileName")
                        .HasColumnType("text");

                    b.Property<int>("FaceId")
                        .HasColumnType("integer");

                    b.Property<string>("IllustFileName")
                        .HasColumnType("text");

                    b.Property<int>("LocalFlag")
                        .HasColumnType("integer");

                    b.Property<int>("MagicType")
                        .HasColumnType("integer");

                    b.Property<int>("Material")
                        .HasColumnType("integer");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<int>("ModelId")
                        .HasColumnType("integer");

                    b.Property<int>("MotionFileId")
                        .HasColumnType("integer");

                    b.Property<int>("NameId")
                        .HasColumnType("integer");

                    b.Property<int>("RidingMotionType")
                        .HasColumnType("integer");

                    b.Property<int>("RidingSpeed")
                        .HasColumnType("integer");

                    b.Property<int>("RunSpeed")
                        .HasColumnType("integer");

                    b.Property<decimal>("Scale")
                        .HasColumnType("numeric");

                    b.Property<string>("ScriptText")
                        .HasColumnType("text");

                    b.Property<decimal>("Size")
                        .HasColumnType("numeric");

                    b.Property<int>("Skill1Id")
                        .HasColumnType("integer");

                    b.Property<int>("Skill1TextId")
                        .HasColumnType("integer");

                    b.Property<int>("Skill2Id")
                        .HasColumnType("integer");

                    b.Property<int>("Skill2TextId")
                        .HasColumnType("integer");

                    b.Property<int>("Skill3Id")
                        .HasColumnType("integer");

                    b.Property<int>("Skill3TextId")
                        .HasColumnType("integer");

                    b.Property<int>("Skill4Id")
                        .HasColumnType("integer");

                    b.Property<int>("Skill4TextId")
                        .HasColumnType("integer");

                    b.Property<int>("Skill5Id")
                        .HasColumnType("integer");

                    b.Property<int>("Skill5TextId")
                        .HasColumnType("integer");

                    b.Property<int>("SlantType")
                        .HasColumnType("integer");

                    b.Property<int>("StandardRunSpeed")
                        .HasColumnType("integer");

                    b.Property<int>("StandardWalkSpeed")
                        .HasColumnType("integer");

                    b.Property<int>("StatId")
                        .HasColumnType("integer");

                    b.Property<decimal>("TargetFxSize")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TargetX")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TargetY")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TargetZ")
                        .HasColumnType("numeric");

                    b.Property<int>("TextFeatureId")
                        .HasColumnType("integer");

                    b.Property<int>("TextNameId")
                        .HasColumnType("integer");

                    b.Property<int>("TextureGroup")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int>("WalkType")
                        .HasColumnType("integer");

                    b.Property<int>("WeaponType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EvolveTargetId");

                    b.ToTable("SummonResources");
                });

            modelBuilder.Entity("DevConsole.Models.Arcadia.SummonResourceEntity", b =>
                {
                    b.HasOne("DevConsole.Models.Arcadia.SummonResourceEntity", "EvolveTarget")
                        .WithMany()
                        .HasForeignKey("EvolveTargetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EvolveTarget");
                });
#pragma warning restore 612, 618
        }
    }
}
