using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YouYou
{
	/// <summary>
	/// AssetInfo的主Asset实体
	/// </summary>
	public class AssetInfoEntity
	{
		/// <summary>
		/// 资源完整名称(路径)
		/// </summary>
		public string AssetFullName;

		/// <summary>
		/// 所属资源包(这个资源在哪一个Assetbundle里)
		/// </summary>
		public string AssetBundleName;

		/// <summary>
		/// 依赖资源包列表
		/// </summary>
		public List<string> DependsAssetBundleList;
	}
}
