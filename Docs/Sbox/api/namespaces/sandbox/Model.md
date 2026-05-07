# Sandbox.Model

A model.

- **Kind:** sealed class
- **Namespace:** `Sandbox`
- **Assembly:** `Sandbox.Engine`
- **Base:** `Sandbox.Resource`

## Properties

- `System.Int32 AnimationCount`
  - Number of animations this model has.
- `System.Collections.Generic.IReadOnlyList<System.String> AnimationNames`
- `Sandbox.AnimationGraph AnimGraph`
  - Get the animgraph this model uses.
- `Sandbox.ModelAttachments Attachments`
  - Access to bones of this model.
- `System.Int32 AttachmentCount`
  - Returns amount of attachment points this model has.
- `Sandbox.ModelParts Parts`
  - Access to body parts of this model.
- `System.Int32 BodyGroupCount`
- `System.UInt64 DefaultBodyGroupMask`
- `System.Collections.Generic.IEnumerable<Sandbox.Model.BodyPart> BodyParts`
- `BBox Bounds`
  - Total bounds of all the meshes.
- `BBox PhysicsBounds`
  - Total bounds of all the physics shapes.
- `BBox RenderBounds`
  - Render view bounds.
- `System.Boolean IsValid`
- `System.Boolean IsError`
  - Whether this model is an error model or invalid or not.
- `System.String Name`
  - Name of the model, usually being its file path.
- `System.Boolean IsProcedural`
  - Whether this model is procedural, i.e. it was created at runtime via `Sandbox.ModelBuilder.Create`.
- `System.Int32 MeshCount`
  - Total number of meshes this model is made out of.
- `Sandbox.Engine.Utility.RayTrace.MeshTraceRequest Trace`
  - Trace against the triangles in this mesh
- `Sandbox.Model.CommonData Data`
- `Sandbox.HitboxSet HitboxSet`
  - Access to default hitbox set of this model
- `System.Int32 MaterialGroupCount`
  - Number of material groups this model has.
- `System.Collections.Immutable.ImmutableArray<Sandbox.Material> Materials`
  - Retrieves an enumerable collection of all Materials on the meshes.
This is fast, and cached. The order of these items is the same order used in ModelRenderer.Materials etc
- `Sandbox.ModelMorphs Morphs`
  - Access to bones of this model.
- `System.Int32 MorphCount`
  - Number of morph controllers this model has.
- `Sandbox.PhysicsGroupDescription Physics`
- `Sandbox.BoneCollection Bones`
  - Access to bones of this model.
- `System.Int32 BoneCount`
  - Number of bones this model has.
- `static Sandbox.ModelBuilder Builder`
  - Returns a static `Sandbox.ModelBuilder` instance, allowing for runtime model creation.
- `static Sandbox.Model Cube`
  - A cube model
- `static Sandbox.Model Sphere`
  - A sphere model
- `static Sandbox.Model Plane`
  - A plane model
- `static Sandbox.Model Error`
  - An error model

## Methods

### Static methods

- `static Sandbox.Model Load(System.String filename)`
  - Load a model by file path.
  - `filename`: The file path to load as a model.
  - returns: The loaded model, or null
- `static System.Threading.Tasks.Task<Sandbox.Model> LoadAsync(System.String filename)`
  - Load a model by file path.
  - `filename`: The file path to load as a model.
  - returns: The loaded model, or null

### Instance methods

- `System.String GetAnimationName(System.Int32 animationIndex)`
  - Returns name of an animation at given animation index.
  - `animationIndex`: Animation index to get name of, starting at 0.
  - returns: Name of the animation.
- `System.Nullable<Transform> GetAttachment(System.String name)`
  - Retrieves attachment transform based on given attachment name.
  - `name`: Name of the attachment to retrieve transform of.
  - returns: The attachment transform, or null if attachment by given name is not found.
- `System.Nullable<Transform> GetAttachment(System.Int32 index)`
  - Retrieves attachment transform based on given attachment index.
  - `index`: &gt;Index of the attachment to look up, starting at 0.
  - returns: The attachment transform.
- `System.String GetAttachmentName(System.Int32 index)`
  - Returns name of an attachment at given index.
  - `index`: Index of the attachment to look up, starting at 0.
  - returns: The name of the attachment at given index.
- `System.Boolean TryGetData(T data)`
  - Tries to extract data from model based on the given type's <see cref="T:Sandbox.ModelEditor.GameDataAttribute">ModelDoc.GameDataAttribute</see>.
  - `data`: The extracted data, or default on failure.
  - returns: true if data was extracted successfully, false otherwise.
- `System.Boolean TryGetData(System.Type t, System.Object data)`
  - Tries to extract data from model based on the given type's <see cref="T:Sandbox.ModelEditor.GameDataAttribute">ModelDoc.GameDataAttribute</see>.
  - `data`: The extracted data, or default on failure.
  - `t`: The class with <see cref="T:Sandbox.ModelEditor.GameDataAttribute">ModelDoc.GameDataAttribute</see>.
  - returns: true if data was extracted successfully, false otherwise.
- `System.Boolean HasData()`
  - Tests if this model has generic data based on given type's <see cref="T:Sandbox.ModelEditor.GameDataAttribute">ModelDoc.GameDataAttribute</see>.
This will be faster than testing this via GetData<![CDATA[<>]]>()
- `T GetData()`
  - Extracts data from model based on the given type's <see cref="T:Sandbox.ModelEditor.GameDataAttribute">ModelDoc.GameDataAttribute</see>.
- `System.Collections.Generic.Dictionary<System.String,System.String[]> GetBreakCommands()`
  - Internal function used to get a list of break commands the model has.
- `System.String GetMaterialGroupName(System.Int32 groupIndex)`
  - Returns name of a material group at given group index.
  - `groupIndex`: Group index to get name of, starting at 0.
  - returns: Name of the group.
- `System.Int32 GetMaterialGroupIndex(System.String groupIndex)`
  - Retrieves the index of a material group given its name.
  - `groupIndex`: The name of the material group.
  - returns: The index of the material group, or a negative value if the group does not exist.
- `System.Collections.Generic.IEnumerable<Sandbox.Material> GetMaterials(System.Int32 groupIndex)`
  - Retrieves an enumerable collection of Materials belonging to a specified group.
  - `groupIndex`: The index of the material group. Default value is 0.
  - returns: An IEnumerable of Materials in the specified group.
- `System.Collections.Generic.IEnumerable<Sandbox.Material> GetMaterials(System.String groupName)`
  - Retrieves an enumerable collection of Materials belonging to a specified group.
  - `groupName`: The name of the material group.
  - returns: An IEnumerable of Materials in the specified group.
- `System.String GetMorphName(System.Int32 morph)`
  - Returns name of a morph controller at given index.
  - `morph`: Morph controller index to get name of, starting at 0.
  - returns: Name of the morph controller at given index.
- `System.Single GetVisemeMorph(System.String viseme, System.Int32 morph)`
  - Get morph weight for viseme.
- `System.Byte[] SaveToVmdl()`
- `System.Threading.Tasks.Task<System.Byte[]> SaveToVmdlAsync()`
- `System.String GetBoneName(System.Int32 boneIndex)`
  - Returns name of a bone at given bone index.
  - `boneIndex`: Bone index to get name of, starting at 0.
  - returns: Name of the bone.
- `System.Int32 GetBoneParent(System.Int32 boneIndex)`
  - Returns the id of given bone's parent bone.
  - `boneIndex`: The bone to look up parent of.
  - returns: The id of the parent bone, or -1 if given bone has no parent.
- `Transform GetBoneTransform(System.Int32 boneIndex)`
  - Returns transform of given bone at bind position.
- `Transform GetBoneTransform(System.String bone)`
  - Returns transform of given bone at bind position.
- `System.Collections.Generic.Dictionary<Sandbox.BoneCollection.Bone,Sandbox.GameObject> CreateBoneObjects(Sandbox.GameObject root)`
  - Creates a dictionary of bone names to game objects, where each game object is a bone object in the scene.
- `Sandbox.Vertex[] GetVertices()`
  - Experimental!
- `System.UInt32[] GetIndices()`
  - Experimental!
- `System.Int32 GetIndexCount(System.Int32 drawcall)`
- `System.Int32 GetIndexStart(System.Int32 drawcall)`
- `System.Int32 GetBaseVertex(System.Int32 drawcall)`
