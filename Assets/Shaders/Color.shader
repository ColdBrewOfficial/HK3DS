Shader "Katworks/Base/Color"
{
	Properties {
        _Color ("Color (RGB)", Color) = (1,1,1,1)
		[Enum(UnityEngine.Rendering.CullMode)] _Cull ("Cull", Float) = 2
	}

	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100
		Cull [_Cull]
		
		Pass {
			Name "COLOR"

			SetTexture [_] {
                constantColor [_Color]
                combine constant
            }
		}
	}
}