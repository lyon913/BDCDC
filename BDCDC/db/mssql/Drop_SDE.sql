
--删除arcsde的表
drop table GDB_ITEMRELATIONSHIPS
drop table GDB_ITEMS
drop table GDB_ITEMTYPES
drop table GDB_REPLICALOG
drop table GDB_ITEMRELATIONSHIPTYPES
drop table GDB_TABLES_LAST_MODIFIED

drop table i2
drop table i3
drop table i4
drop table i5
drop table i6
drop table i7
drop table i8
drop table i9
drop table i10
drop table i11
drop table i12
drop table i13
drop table i14
drop table i15

drop table SDE_GEOMETRY1
drop table SDE_GEOMETRY2
drop table SDE_GEOMETRY3
drop table SDE_GEOMETRY4
drop table SDE_GEOMETRY5
drop table SDE_GEOMETRY6
drop table SDE_GEOMETRY7
drop table SDE_GEOMETRY8
drop table SDE_GEOMETRY9
drop table SDE_GEOMETRY10

drop table SDE_archives
drop table SDE_column_registry
drop table SDE_dbtune
drop table SDE_geometry_columns
drop table SDE_layer_locks
drop table SDE_layer_stats
drop table SDE_layers
drop table SDE_lineages_modified
drop table SDE_locators
drop table SDE_logfile_pool
drop table SDE_metadata
drop table SDE_mvtables_modified
drop table SDE_object_ids
drop table SDE_object_locks
drop table SDE_process_information
drop table SDE_raster_columns
drop table SDE_server_config
drop table SDE_spatial_references
drop table SDE_state_lineages
drop table SDE_state_locks
drop table SDE_states
drop table SDE_table_locks
drop table SDE_table_registry
drop table SDE_tables_modified
drop table SDE_version
drop table SDE_versions
drop table SDE_xml_columns
drop table SDE_xml_index_tags
drop table SDE_xml_indexes


go
--删除视图
drop view dbtune
drop view ST_GEOMETRY_COLUMNS
drop view ST_SPATIAL_REFERENCE_SYSTEMS
drop view SDE_generate_guid

go
--删除存储过程
DROP PROCEDURE create_version
DROP PROCEDURE delete_version
DROP PROCEDURE edit_version
DROP PROCEDURE gdb_util_release
DROP PROCEDURE geometry_columns
DROP PROCEDURE geometry_type
DROP PROCEDURE get_extent
DROP PROCEDURE get_filtered_table_names

DROP PROCEDURE i2_get_ids
DROP PROCEDURE i2_return_ids
DROP PROCEDURE i3_get_ids
DROP PROCEDURE i3_return_ids
DROP PROCEDURE i4_get_ids
DROP PROCEDURE i4_return_ids
DROP PROCEDURE i5_get_ids
DROP PROCEDURE i5_return_ids
DROP PROCEDURE i6_get_ids
DROP PROCEDURE i6_return_ids
DROP PROCEDURE i7_get_ids
DROP PROCEDURE i7_return_ids
DROP PROCEDURE i8_get_ids
DROP PROCEDURE i8_return_ids
DROP PROCEDURE i9_get_ids
DROP PROCEDURE i9_return_ids
DROP PROCEDURE i10_get_ids
DROP PROCEDURE i10_return_ids
DROP PROCEDURE i11_get_ids
DROP PROCEDURE i11_return_ids
DROP PROCEDURE i12_get_ids
DROP PROCEDURE i12_return_ids
DROP PROCEDURE i13_get_ids
DROP PROCEDURE i13_return_ids
DROP PROCEDURE i14_get_ids
DROP PROCEDURE i14_return_ids
DROP PROCEDURE i15_get_ids
DROP PROCEDURE i15_return_ids

DROP PROCEDURE isGeoDatabase
DROP PROCEDURE next_globalid
DROP PROCEDURE next_rowid

DROP PROCEDURE SDE_archives_def_delete
DROP PROCEDURE SDE_archives_def_insert
DROP PROCEDURE SDE_col_registry_def_update
DROP PROCEDURE SDE_column_registry_def_delete
DROP PROCEDURE SDE_column_registry_def_insert
DROP PROCEDURE SDE_column_registry_def_update
DROP PROCEDURE SDE_current_version_not_default
DROP PROCEDURE SDE_current_version_writable
DROP PROCEDURE SDE_dbtune_def_delete
DROP PROCEDURE SDE_dbtune_def_insert
DROP PROCEDURE SDE_dbtune_def_truncate
DROP PROCEDURE SDE_dbtune_def_update
DROP PROCEDURE SDE_generator_release
DROP PROCEDURE SDE_geocol_def_change_table_name
DROP PROCEDURE SDE_geocol_def_delete
DROP PROCEDURE SDE_geocol_def_insert
DROP PROCEDURE SDE_geocol_def_update
DROP PROCEDURE SDE_get_current_user_name
DROP PROCEDURE SDE_get_globals
DROP PROCEDURE SDE_get_primary_oid
DROP PROCEDURE SDE_keyset_delete
DROP PROCEDURE SDE_keyset_remove
DROP PROCEDURE SDE_last_lineage_mod_def_insert
DROP PROCEDURE SDE_last_modified_def_update
DROP PROCEDURE SDE_layer_check_lock_conflicts
DROP PROCEDURE SDE_layer_def_change_table_name
DROP PROCEDURE SDE_layer_def_delete
DROP PROCEDURE SDE_layer_def_envelope_update
DROP PROCEDURE SDE_layer_def_insert
DROP PROCEDURE SDE_layer_def_mask_update
DROP PROCEDURE SDE_layer_def_update
DROP PROCEDURE SDE_layer_lock_def_delete
DROP PROCEDURE SDE_layer_lock_def_delete_user
DROP PROCEDURE SDE_layer_lock_def_insert
DROP PROCEDURE SDE_layer_lock_def_update
DROP PROCEDURE SDE_layer_srid_update
DROP PROCEDURE SDE_layer_stats_def_delete
DROP PROCEDURE SDE_layer_stats_def_insert
DROP PROCEDURE SDE_layer_stats_def_update
DROP PROCEDURE SDE_locator_def_delete
DROP PROCEDURE SDE_locator_def_insert
DROP PROCEDURE SDE_locator_def_update
DROP PROCEDURE SDE_logfile_pool_get_id
DROP PROCEDURE SDE_logfile_pool_release_id
DROP PROCEDURE SDE_metadata_def_delete
DROP PROCEDURE SDE_metadata_def_insert
DROP PROCEDURE SDE_metadata_def_update
DROP PROCEDURE SDE_mvmodified_table_del_base_save
DROP PROCEDURE SDE_mvmodified_table_insert
DROP PROCEDURE SDE_new_branch_state
DROP PROCEDURE SDE_object_check_lock_conflicts
DROP PROCEDURE SDE_object_lock_def_delete
DROP PROCEDURE SDE_object_lock_def_delete_user
DROP PROCEDURE SDE_object_lock_def_insert
DROP PROCEDURE SDE_parse_version_name
DROP PROCEDURE SDE_pinfo_def_delete
DROP PROCEDURE SDE_pinfo_def_insert
DROP PROCEDURE SDE_pinfo_def_update
DROP PROCEDURE SDE_procedure_release
DROP PROCEDURE SDE_purge_processes
DROP PROCEDURE SDE_rascol_def_delete
DROP PROCEDURE SDE_rascol_def_insert
DROP PROCEDURE SDE_rascol_def_rename
DROP PROCEDURE SDE_rascol_def_update
DROP PROCEDURE SDE_rascol_def_update_migrate
DROP PROCEDURE SDE_rascol_spatial_reference_update
DROP PROCEDURE SDE_rascol_srid_update
DROP PROCEDURE SDE_registry_clear_modified
DROP PROCEDURE SDE_registry_def_change_table_name
DROP PROCEDURE SDE_registry_def_delete
DROP PROCEDURE SDE_registry_def_insert
DROP PROCEDURE SDE_registry_def_update
DROP PROCEDURE SDE_server_config_insert
DROP PROCEDURE SDE_set_globals
DROP PROCEDURE SDE_sref_def_delete
DROP PROCEDURE SDE_sref_def_insert
DROP PROCEDURE SDE_sref_def_update
DROP PROCEDURE SDE_state_check_lock_conflicts
DROP PROCEDURE SDE_state_def_delete
DROP PROCEDURE SDE_state_def_insert
DROP PROCEDURE SDE_state_def_trim_states
DROP PROCEDURE SDE_state_def_update
DROP PROCEDURE SDE_state_lock_def_delete
DROP PROCEDURE SDE_state_lock_def_delete_user
DROP PROCEDURE SDE_state_lock_def_insert
DROP PROCEDURE SDE_state_new_edit
DROP PROCEDURE SDE_state_trim_pre_delete
DROP PROCEDURE SDE_table_check_lock_conflicts
DROP PROCEDURE SDE_table_lock_def_delete
DROP PROCEDURE SDE_table_lock_def_delete_user
DROP PROCEDURE SDE_table_lock_def_insert
DROP PROCEDURE SDE_versions_def_change_state
DROP PROCEDURE SDE_versions_def_delete
DROP PROCEDURE SDE_versions_def_insert
DROP PROCEDURE SDE_versions_def_rename
DROP PROCEDURE SDE_versions_def_rename_parent
DROP PROCEDURE SDE_versions_def_update
DROP PROCEDURE SDE_xml_columns_def_delete
DROP PROCEDURE SDE_xml_columns_def_insert
DROP PROCEDURE SDE_xml_columns_def_update
DROP PROCEDURE SDE_xml_index_tags_def_delete
DROP PROCEDURE SDE_xml_index_tags_def_insert
DROP PROCEDURE SDE_xml_index_tags_def_update
DROP PROCEDURE SDE_xml_indexes_def_delete
DROP PROCEDURE SDE_xml_indexes_def_insert
DROP PROCEDURE SDE_xml_indexes_def_update
DROP PROCEDURE set_current_version
DROP PROCEDURE set_default
DROP PROCEDURE spatial_ref_info

go
--删除约束

ALTER TABLE dbo.XZQ	DROP CONSTRAINT g8_ck 
go
ALTER TABLE dbo.DJQ	DROP CONSTRAINT g4_ck
go
ALTER TABLE dbo.DJZQ	DROP CONSTRAINT g5_ck
go
ALTER TABLE dbo.JZD	DROP CONSTRAINT g6_ck
go
ALTER TABLE dbo.JZX	DROP CONSTRAINT g7_ck
go
ALTER TABLE dbo.ZDJBXX	DROP CONSTRAINT g2_ck
go
ALTER TABLE dbo.ZRZ	DROP CONSTRAINT g3_ck
go
ALTER TABLE dbo.XZQJX	DROP CONSTRAINT g9_ck
go
ALTER TABLE dbo.GZW	DROP CONSTRAINT g10_ck
go
