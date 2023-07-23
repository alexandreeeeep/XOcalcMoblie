﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XOapp.Models;

namespace XOapp.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private string text;
        private string description;
        public string[] ItemName = {
  "small wheel_15_3_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"small wheel st_15_3_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"medium wheel_15_3_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"medium wheel st_15_3_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"sprinter_75_15_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"huntsman_75_15_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"wwt1_75_15_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"docker_75_15_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"lm-54 chord_30_6_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"lupara_30_6_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"avenger 57mm_30_6_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"fuel barrel_60_12_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"car jack_20_4_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"radio_20_4_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"rs-1 ruby_35_8_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"b-1 aviator_55_11_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"r-1 breeze_20_4_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"repair kit_300_90_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"decor container_400_0_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"engineer flag_300_150_0_0_0_0_0_Empty_0_Empty_0_Empty_0_0",
"paint container_400_400_0_300_0_300_0_Empty_0_Empty_0_Empty_0_0",

"growl_700_130_0_0_0_0_0_sprinter_1_lupara_1_Empty_0_3",
"wyvern_700_130_0_0_0_0_0_huntsman_1_rs-1 ruby_1_Empty_0_3",
"trucker_700_130_0_0_0_0_0_docker_1_sprinter_1_Empty_0_3",
"st-m23 defender_650_130_0_0_0_0_0_lm-54 chord_1_r-1 breeze_1_Empty_0_3",
"vector_650_130_0_0_0_0_0_lm-54 chord_1_car jack_1_Empty_0_3",
"sledgehammer_650_130_0_0_0_0_0_lupara_1_car jack_1_Empty_0_3",
"spitfire_650_130_0_0_0_0_0_lupara_1_b-1 aviator_1_Empty_0_3",
"ac43 rapier_650_130_0_0_0_0_0_lm-54 chord_1_b-1 aviator_1_Empty_0_3",
"little boy 6lb_650_130_0_0_0_0_0_avenger 57mm_1_fuel barrel_1_Empty_0_3",
"judge 76mm_650_130_0_0_0_0_0_avenger 57mm_1_medium wheel st_1_Empty_0_3",
"wasp_650_130_0_0_0_0_0_avenger 57mm_1_fuel barrel_1_Empty_0_3",
"borer_650_130_0_0_0_0_0_car jack_1_r-1 breeze_1_Empty_0_3",
"ad-12 falcon_650_130_0_0_0_0_0_lm-54 chord_1_rs-1 ruby_1_Empty_0_3",
"dt cobra_650_130_0_0_0_0_0_radio_1_lupara_1_Empty_0_3",
"fuel tank_650_130_0_0_0_0_0_fuel barrel_1_docker_1_Empty_0_3",
"rd-1 listener_650_130_0_0_0_0_0_rs-1 ruby_1_fuel barrel_1_Empty_0_3",
"ts-1 horizon_650_130_0_0_0_0_0_radio_1_small wheel_1_Empty_0_3",
"big g_700_130_0_0_0_0_0_b-1 aviator_1_avenger 57mm_1_Empty_0_3",
"blastoff_650_130_0_0_0_0_0_b-1 aviator_1_rs-1 ruby_1_Empty_0_3",
"r-2 chill_650_130_0_0_0_0_0_b-1 aviator_1_radio_1_Empty_0_3",
"cs taymyr_650_130_0_0_0_0_0_r-1 breeze_1_huntsman_1_Empty_0_3",
"ammo pack_650_130_0_0_0_0_0_car jack_1_radio_1_Empty_0_3",
"studded wheel_600_130_0_0_0_0_0_medium wheel_1_small wheel_1_Empty_0_3",
"studded wheel st_600_130_0_0_0_0_0_medium wheel st_1_small wheel st_1_Empty_0_3",
"chained wheel_600_130_0_0_0_0_0_medium wheel_1_small wheel_1_Empty_0_3",
"chained wheel st_600_130_0_0_0_0_0_medium wheel st_1_small wheel st_1_Empty_0_3",
"balloon tyre_600_130_0_0_0_0_0_medium wheel_2_Empty_0_Empty_0_3",
"balloon tyre st_600_130_0_0_0_0_0_small wheel st_2_Empty_0_Empty_0_3",
"racing wheel_600_130_0_0_0_0_0_medium wheel_1_small wheel_1_Empty_0_3",
"racing wheel st_600_130_0_0_0_0_0_medium wheel st_1_small wheel st_1_Empty_0_3",
"landing gear_600_130_0_0_0_0_0_medium wheel_1_small wheel_1_Empty_0_3",
"landing gear st_600_130_0_0_0_0_0_medium wheel st_1_small wheel st_1_Empty_0_3",
"large wheel_600_130_0_0_0_0_0_small wheel_1_wwt1_1_Empty_0_3",
"large wheel st_600_130_0_0_0_0_0_medium wheel st_1_wwt1_1_Empty_0_3",

"bat_50_100_100_0_50_0_0_growl_1_big g_1_Empty_0_6",
"pilgrim_50_100_100_0_50_0_0_wyvern_1_ad-12 falcon_1_Empty_0_6",
"jawbreaker_50_100_100_0_50_0_0_trucker_1_rd-1 listener_1_Empty_0_6",
"m-37 piercer_250_100_100_0_50_0_0_vector_1_big g_1_Empty_0_6",
"sinus-0_50_100_100_0_50_0_0_vector_1_ac43 rapier_1_Empty_0_6",
"goblin_50_100_100_0_50_0_0_wasp_1_spitfire_1_Empty_0_6",
"junkbow_50_100_100_0_50_0_0_sledgehammer_1_growl_1_Empty_0_6",
"mace_50_100_100_0_50_0_0_sledgehammer_1_spitfire_1_Empty_0_6",
"ac50 storm_50_100_100_0_50_0_0_st-m23 defender_1_ac43 rapier_1_Empty_0_6",
"zs-33 hulk_50_100_100_0_50_0_0_judge 76mm_1_fuel tank_1_Empty_0_6",
"prosecutor 76mm_50_100_100_0_50_0_0_judge 76mm_1_ammo pack_1_Empty_0_6",
"pyralid_50_100_100_0_50_0_0_wasp_1_studded wheel_1_Empty_0_6",
"synthesis_50_100_100_0_50_0_0_vector_1_wyvern_1_Empty_0_6",
"boom_50_100_100_0_50_0_0_wasp_1_fuel tank_1_Empty_0_6",
"tempura_200_100_200_0_30_0_0_borer_1_rd-1 listener_1_Empty_0_6",
"buzzsaw_50_100_100_0_50_0_0_blastoff_1_little boy 6lb_1_Empty_0_6",
"ad-13 hawk_50_100_100_0_50_0_0_ad-12 falcon_1_cs taymyr_1_Empty_0_6",
"sidekick_50_100_100_0_50_0_0_dt cobra_1_borer_1_Empty_0_6",
"dt python_50_100_100_0_50_0_0_dt cobra_1_r-2 chill_1_Empty_0_6",
"summator_50_100_100_0_50_0_0_st-m23 defender_1_borer_1_Empty_0_6",
"chameleon_50_100_100_0_50_0_0_landing gear_1_cs taymyr_1_Empty_0_6",
"ka-1 discharger_50_100_100_0_50_0_0_cs taymyr_1_trucker_1_Empty_0_6",
"oculus vi_50_100_100_0_50_0_0_rd-1 listener_1_ts-1 horizon_1_Empty_0_6",
"maxwell_50_100_100_0_50_0_0_landing gear st_1_ts-1 horizon_1_Empty_0_6",
"ampere_50_100_100_0_50_0_0_racing wheel st_1_r-2 chill_1_Empty_0_6",
"pu-1 charge_50_100_100_0_50_0_0_dt cobra_1_ts-1 horizon_1_Empty_0_6",
"hardcore_50_100_100_0_50_0_0_blastoff_1_cs taymyr_1_Empty_0_6",
"razorback_50_100_100_0_50_0_0_trucker_1_little boy 6lb_1_Empty_0_6",
"dun horse_50_100_100_0_50_0_0_racing wheel_1_r-2 chill_1_Empty_0_6",
"genesis_50_100_100_0_50_0_0_ad-12 falcon_1_ammo pack_1_Empty_0_6",
"lunar iv_50_100_100_0_50_0_0_racing wheel_1_landing gear_1_Empty_0_6",
"lunar iv st_50_100_100_0_50_0_0_racing wheel st_1_landing gear st_1_Empty_0_6",
"camber_200_200_100_0_30_0_0_racing wheel_1_balloon tyre_1_Empty_0_6",
"camber st_200_200_100_0_30_0_0_racing wheel st_1_balloon tyre st_1_Empty_0_6",
"shiv_50_100_100_0_50_0_0_studded wheel_1_chained wheel_1_Empty_0_6",
"shiv st_50_100_100_0_50_0_0_studded wheel st_1_chained wheel st_1_Empty_0_6",
"array_50_100_100_0_50_0_0_chained wheel_1_studded wheel_1_Empty_0_6",
"array st_50_100_100_0_50_0_0_chained wheel st_1_studded wheel st_1_Empty_0_6",
"apc wheel_50_100_100_0_50_0_0_large wheel_1_balloon tyre_1_Empty_0_6",
"apc wheel st_50_100_100_0_50_0_0_large wheel st_1_balloon tyre st_1_Empty_0_6",
"twin wheel_50_100_100_0_50_0_0_large wheel_1_balloon tyre_1_Empty_0_6",
"twin wheel st_50_100_100_0_50_0_0_large wheel st_1_balloon tyre st_1_Empty_0_6",

"huginn_450_450_200_0_100_0_0_pyralid_1_razorback_1_oculus vi_1_15",
"jannabi_250_250_200_100_60_0_0_bat_1_tempura_1_razorback_1_15",
"werewolf_100_150_200_0_100_0_0_bat_1_shiv st_1_ampere_1_15",
"harpy_100_150_200_0_100_0_0_bat_1_shiv_1_sinus-0_1_15",
"aggressor_100_150_200_100_60_0_0_hardcore_1_goblin_1_buzzsaw_1_15",
"quantum_100_150_200_0_100_0_0_pilgrim_1_genesis_1_ad-13 hawk_1_15",
"photon_100_150_200_0_100_0_0_pilgrim_1_synthesis_1_ad-13 hawk_1_15",
"omnibox_100_150_200_0_100_0_0_pilgrim_1_array st_1_jawbreaker_1_15",
"humpback_100_150_200_0_100_0_0_jawbreaker_1_apc wheel_1_razorback_1_15",
"bastion_100_150_200_0_100_0_0_jawbreaker_1_apc wheel st_1_pu-1 charge_1 _15",
"gungnir_450_450_200_0_100_0_0_ac62 therm_1_sinus-0_1_m-37 piercer_1_15",
"m-29 protector_100_150_200_0_100_0_0_sinus-0_1_dun horse_1_chameleon_1_15",
"m-38 fidget_600_600_200_0_100_0_0_m-37 piercer_1_ac50 storm_1_razorback_1_15",
"spectre-2_100_150_200_0_100_0_0_sinus-0_1_ad-13 hawk_1_maxwell_1_15",
"mg13 equalizer_100_150_200_0_100_0_0_ac50 storm_1_sinus-0_1_ampere_1_15",
"caucasus_100_150_200_0_100_0_0_prosecutor 76mm_1_jawbreaker_1_apc wheel_1_15",
"gremlin_100_250_200_100_60_0_0_goblin_1_mace_1_boom_1_15",
"fafnir_100_150_200_0_100_0_0_junkbow_2_zs-33 hulk_1_Empty_0_15",
"thunderbolt_100_150_200_0_100_0_0_mace_1_goblin_1_buzzsaw_1_15",
"rupture_100_150_200_0_100_0_0_goblin_1_hardcore_1_buzzsaw_1_15",
"ac72 whirlwind_100_150_200_0_100_0_0_ac50 storm_1_chameleon_1_sinus-0_1_15",
"whirl_100_150_200_0_100_0_0_ac50 storm_1_apc wheel_1_sidekick_1_15",
"zs-34 fat man_100_150_200_0_100_0_0_zs-33 hulk_2_twin wheel st_1_Empty_0_15",
"executioner 88mm_100_150_200_0_100_0_0_prosecutor 76mm_1_twin wheel_1_oculus vi_1_15",
"cricket_100_150_200_0_100_0_0_goblin_1_boom_1_mace_1_15",
"pyre_100_150_200_0_100_0_0_prosecutor 76mm_1_oculus vi_1_dt python_1_15",
"nest_100_150_200_0_100_0_0_zs-33 hulk_1_pu-1 charge_1_dt python_1_15",
"clarinet tow_100_150_200_0_100_0_0_dt python_1_sidekick_1_apc wheel st_1_15",
"thresher_100_150_200_100_60_0_0_ac50 storm_1_dun horse_1_maxwell_1_15",
"gl-55 impulse_100_150_200_100_60_0_0_prosecutor 76mm_1_pu-1 charge_1_dt python_1_15",
"aurora_100_150_200_100_60_0_0_synthesis_1_lunar iv st_1_ampere_1_15",
"gravastar_100_150_200_100_60_0_0_synthesis_1_lunar iv_1_mace_1_15",
"quasar_100_150_200_100_60_0_0_zs-33 hulk_1_synthesis_1_genesis_1_15",
"prometheus v_100_150_200_100_60_0_0_synthesis_1_genesis_1_maxwell_1_15",
"trigger_100_150_200_0_100_0_0_summator_1_oculus vi_1_lunar iv st_1_15",
"blockchain_100_150_200_0_100_0_0_summator_1_mace_1_dun horse_1_15",
"phoenix_100_150_200_0_100_0_0_junkbow_1_shiv_1_boom_1_15",
"lancelot_100_150_200_0_100_0_0_boom_1_goblin_1_hardcore_1_15",
"mauler_100_150_200_0_100_0_0_buzzsaw_1_boom_1_goblin_1_15",
"incinerator_100_150_200_0_100_0_0_shiv_1_junkbow_1_pu-1 charge_1_15",
"md-3 owl_100_150_200_0_100_0_0_ad-13 hawk_1_ampere_1_sinus-0_1_15",
"fuze_100_150_200_0_100_0_0_hardcore_1_boom_1_goblin_1_15",
"rt anaconda_100_150_200_0_100_0_0_dt python_1_pu-1 charge_1_twin wheel st_1_15",
"barrier ix_100_150_200_0_100_0_0_pilgrim_1_lunar iv_1_dt python_1_15",
"yaoguai_100_150_200_0_100_0_0_tempura_1_sidekick_1_ad-13 hawk_1_15",
"skinner_100_150_200_0_100_0_0_junkbow_1_shiv st_1_mace_1_15",
"enlightenment_100_250_200_100_60_0_0_tempura_1_oculus vi_1_pyralid_1_15",
"tormentor_100_150_200_0_100_0_0_bat_1_junkbow_1_ad-13 hawk_1_15",
"chameleon mk2_100_150_200_0_100_0_0_chameleon_1_maxwell_1_ac50 storm_1_15",
"ka-2 flywheel_100_150_200_0_100_0_0_ka-1 discharger_1_razorback_1_oculus vi_1_15",
"verifier_100_150_200_0_100_0_0_array_1_oculus vi_1_sidekick_1_15",
"doppler_100_150_200_0_100_0_0_maxwell_2_chameleon_1_Empty_0_15",
"rd-2 keen_100_150_200_0_100_0_0_oculus vi_1_twin wheel_1_pu-1 charge_1_15",
"neutrino_100_150_200_0_100_0_0_lunar iv_1_genesis_1_twin wheel st_1_15",
"gasgen_100_150_200_0_100_0_0_buzzsaw_1_goblin_1_boom_1_15",
"oppressor_100_150_200_0_100_0_0_bat_1_shiv_1_hardcore_1_15",
"hot red_100_150_200_0_100_0_0_hardcore_1_goblin_1_mace_1_15",
"colossus_100_150_200_0_100_0_0_razorback_1_twin wheel_1_zs-33 hulk_1_15",
"cheetah_100_150_200_0_100_0_0_dun horse_1_chameleon_1_ac50 storm_1_15",
"hermes_100_150_200_0_100_0_0_hardcore_1_boom_1_buzzsaw_1_15",
"rn seal_100_150_200_0_100_0_0_ampere_1_maxwell_1_dun horse_1_15",
"shiver_100_150_200_0_100_0_0_buzzsaw_1_mace_1_hardcore_1_15",
"expanded ammo pack_100_150_200_0_100_0_0_oculus vi_1_pu-1 charge_1_prosecutor 76mm_1_15",
"buggy wheel st_250_250_200_100_60_0_0_buzzsaw_1_mace_1_boom_1_15",
"buggy wheel_250_250_200_100_60_0_0_buzzsaw_1_hardcore_1_mace_1_15",
"hermit st_100_150_200_0_100_0_0_hardcore_1_mace_1_boom_1_15",
"hermit_100_150_200_0_100_0_0_buzzsaw_1_goblin_1_boom_1_15",
"bigfoot st_100_250_200_0_100_0_0_shiv st_1_bat_1_twin wheel st_1_15",
"bigfoot_100_250_200_0_100_0_0_shiv_1_bat_1_twin wheel_1_15",
"omni_100_250_200_0_100_0_0_camber_1_camber st_1_twin wheel st_1_15",
"small track_100_150_200_0_100_0_0_hardcore_1_buzzsaw_1_mace_1_15",
"hardened track_100_150_200_0_100_0_0_ampere_1_chameleon_1_dun horse_1_15",
"armored track_100_150_200_0_100_0_0_twin wheel_1_twin wheel st_1_razorback_1_15",
"sleipnir_450_450_200_0_100_0_0_m-25 guardian_1_ampere_1_buzzsaw_1_15",
"icarus vii_100_150_200_0_100_0_0_lunar iv st_1_lunar iv_1_dun horse_1_15",
"ml 200_100_150_200_0_100_0_0_sidekick_1_apc wheel_1_razorback_1_15",
"bigram_100_150_200_0_100_0_0_array_1_array st_1_apc wheel_1_15",
"meat grinder_100_150_200_0_100_0_0_shiv_1_shiv st_1_buzzsaw_1_15",

"muninn_0_750_600_750_0_600_0_huginn_2_hermit st_2_mg13 equalizer_1_75",
"griffon_100_750_0_750_0_750_0_harpy_2_rupture_2_neutrino_1_75",
"beholder_100_750_0_750_0_750_0_chameleon mk2_2_hermit_2_nest_1_75",
"nova_100_750_0_750_0_750_0_photon_2_whirl_2_mauler_1_75",
"yokozuna_100_750_0_750_0_750_0_jannabi_2_enlightenment_2_yaoguai_1_75",
"cohort_100_750_0_750_0_750_0_humpback_2_gravastar_2_md-3 owl_1_75",
"m-39 imp_1350_1350_0_800_0_800_0_m-38 fidget_2_colossus_2_bigfoot_1_75",
"nothung_0_750_600_750_0_600_0_gungnir_2_omni_1_mg13 equalizer_1_75",
"aspect_100_750_0_750_0_750_0_spectre-2_2_small track_2_rd-2 keen_1_75",
"mg14 arbiter_100_750_0_750_0_750_0_mg13 equalizer_2_rt anaconda_2_gasgen_1_75",
"reaper_100_750_0_750_0_750_0_ac72 whirlwind_2_hot red_2_armored track_1_75",
"nidhogg_100_750_0_750_0_750_0_fafnir_2_cricket_2_bastion_1_75",
"hammerfall_100_750_0_750_0_750_0_thunderbolt_2_cheetah_2_rd-2 keen_1_75",
"cyclone_100_750_0_750_0_750_0_caucasus_2_oppressor_2_hardened track_1_75",
"zs-46 mammoth_100_750_0_750_0_750_0_zs-34 fat man_2_hermes_2_hardened track_1_75",
"bc-17 tsunami_100_750_0_750_0_750_0_clarinet tow_2_icarus vii_2_harpy_1_75",
"hurricane_100_750_0_750_0_750_0_pyre_2_doppler_2_lancelot_1_75",
"retcher_100_750_0_750_0_750_0_md-3 owl_2_gl-55 impulse_2_lancelot_1_75",
"pulsar_100_750_0_750_0_750_0_quasar_2_m-29 protector_2_phoenix_1_75",
"helios_100_750_0_750_0_750_0_prometheus v_2_tormentor_2_ml 200_1_75",
"assembler_100_750_0_750_0_750_0_blockchain_2_bigram_2_verifier_1_75",
"spark iii_100_750_0_750_0_750_0_aurora_2_shiver_2_phoenix_1_75",
"harvester_100_750_0_750_0_750_0_mauler_2_expanded ammo pack_2_rn seal_1_75",
"draco_100_750_0_750_0_750_0_werewolf_2_fuze_2_photon_1_75",
"mandrake_100_750_0_750_0_750_0_humpback_2_executioner 88mm_2_skinner_1_75",
"jubokko_100_750_0_750_0_750_0_yaoguai_2_jannabi_2_enlightenment_1_75",
"fortune_100_750_0_750_0_750_0_incinerator_2_neutrino_2_rn seal_1_75",
"anninhilator_100_750_0_750_0_750_0_trigger_2_omnibox_2_verifier_1_75",
"kaiju_100_750_0_750_0_750_0_enlightenment_2_yaoguai_2_jannabi_1_75",
"aegis-prime_100_750_0_750_0_750_0_barrier ix_2_chameleon mk2_2_meat grinder_1_75",
"apollo iv_100_750_0_750_0_750_0_quantum_2_bigfoot st_2_gasgen_1_75",
"thor-6s_0_750_600_750_0_600_0_sleipnir_2_ka-2 flywheel_2_gasgen_1_75",


"punisher_0_1000_0_1000_0_1000_600_aspect_1_cyclone_1_Empty_0_75",
"jormungandr_0_1000_0_1000_0_1000_600_nidhogg_1_helios_1_Empty_0_75",
"breaker_0_1000_0_1000_0_1000_600_hammerfall_1_fortune_1_Empty_0_75",
"zs-52 mastodon_0_1000_0_1000_0_1000_600_zs-46 mammoth_1_nidhogg_1_Empty_0_75",
"cc-18 tythoon_0_1000_0_1000_0_1000_600_bc-17 tsunami_1_mandrake_1_Empty_0_75",
"flash i_0_1000_0_1000_0_1000_600_spark iii_1_draco_1_Empty_0_75",
"firebug_0_1000_0_1000_0_1000_600_zs-46 mammoth_1_harvester_1_Empty_0_75",
"porcupine_0_1000_0_1000_0_1000_600_retcher_1_hurricane_1_Empty_0_75",
"ripper_0_1000_0_1000_0_1000_600_fortune_1_mg14 arbiter_1_Empty_0_75",
"scorpion_0_1000_0_1000_0_1000_600_pulsar_1_reaper_1_Empty_0_75"};
        private string CalculateCostOfItem(string ItemName)//calculates cost of item
        {
            if (ItemName == "Empty" || ItemName == "")
            {
                return "0";
            }
            if (float.TryParse(ItemName, out float Result))
            {
                return Convert.ToString(Result);
            }
            string[] Item = SeparateList(FindValue(ItemName));//finds the item and creates list
            if (Item[0] == "Item Not Found (make sure the item is spelt correctly and is craftable)")
            {
                return ItemName;
            }
            //calculates value of item and calculates other items if needed
            return Convert.ToString(float.Parse("10") / 100f * float.Parse(Item[1]) +
            float.Parse(Item[2]) * float.Parse("7") / 100f +
               float.Parse("20") / 100 * float.Parse(Item[3]) +
               float.Parse(Item[4]) / 10f * float.Parse("3.5") +
               float.Parse(Item[5]) / 100f * float.Parse("70") +
               float.Parse(Item[6]) / 10f * float.Parse("12") +
               float.Parse(Item[7]) / 10f * float.Parse("600") + 
               float.Parse(CalculateCostOfItem(Item[8])) * float.Parse(Item[9]) +
               float.Parse(CalculateCostOfItem(Item[10])) * float.Parse(Item[11]) +
               float.Parse(CalculateCostOfItem(Item[12])) * float.Parse(Item[13]) + float.Parse(Item[14]));
        }

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            float.TryParse(description, out float value);
            
            return !String.IsNullOrWhiteSpace(text)
                && !float.IsNaN(value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            if (Description == null)
            {
                Description = "Coins: " + Convert.ToString(CalculateCostOfItem(Text));
            }
            Item newItem = new Item()
            {
                Id = Guid.NewGuid().ToString(),
                Text = Text,
                Description = Description

            };
           
            await DataStore.AddItemAsync(newItem);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        string FindValue(string SearchItem)//finds the name in the text file
        {
            // Calling the ReadAllLines() function
            string ItemFound;
            foreach (string line in ItemName)//itarates threw each line
            {
                ItemFound = "";
                foreach (char c in line)
                {//itarates threw each letter 
                    if (c != '_')//finds the end of the first word
                    {
                        ItemFound += c.ToString();
                    }
                    else if (ItemFound == SearchItem && ItemFound != "")
                    {
                        return line;
                    }
                    else { break; }
                }
            }
            return "Item Not Found (make sure the item is spelt correctly and is craftable)";//returns if item not found
        }

        string[] SeparateList(string ItemName)//finds the name in the text file
        {
            string[] Item = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            int CountForList = 0;
            for (int i = 0; i < ItemName.Length; i++)
            {//itarates threw each letter
                if (ItemName[i] != '_')//finds the end of the first word
                {
                    Item[CountForList] += ItemName[i];
                }
                else
                {
                    CountForList++;
                }
            }
            return Item;
        }
    }
}