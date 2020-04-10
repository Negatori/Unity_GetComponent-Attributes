using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rito.Attributes;

/// <summary> 
/// <para/> GetComponent Attributes Demo
/// </summary>
public class CharacterManager_Test : MonoBehaviour
{
    /* ******************************************************************************** *
     *                                    �������                                      *
     * ******************************************************************************** */

    /* ���� �Ķ���� AllowOverwrite : �������� ������ �⺻ ���� false
       false : �ش� �ʵ�/������Ƽ�� null�� ��쿡�� ������Ʈ �ʱ�ȭ ������ �����մϴ�.
       true  : �ش� �ʵ�/������Ƽ�� null�� �ƴ� ��쿡�� ������Ʈ �ʱ�ȭ�� �����Ͽ�, ���� ����*/
    [GetComponent(false)] public Transform _whenAllowOverwriteIsFalse;
    [GetComponent(true)]  public Transform _whenAllowOverwriteIsTrue;

    /* Private, Protected, Public �� ��� ���������ڿ� ���� ���������� �����մϴ�.
       ���̶�Ű���� Ȯ���ϰ� ���� ���, SerializeField�� �Բ� ����մϴ�. */
    [GetComponent]                 private Transform _privateMember1;
    [SerializeField, GetComponent] private Transform _privateMember2;

    /* ������Ƽ�� ���ؼ��� �����ϰ� ����������,
       �ݵ�� Getter�� Setter�� ��� �����ؾ� �մϴ�. */
    [GetComponent] public Collider PropertyMember { get => _col; private set => _col = value; }
    public Collider _col;


    /* ******************************************************************************** *
     *                                     ��ɵ�                                       *
     * ******************************************************************************** */

    /* ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [GetComponent]                public CharacterMovement_Test _movement;

    /* �ڽ� �� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [GetComponentInChildren]      public CharacterInventory_Test _inventory;

    /* ������ �̸��� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       �ش� �̸��� �ڽ� ���� ������Ʈ�� �������� ���� ���, �ƹ��� ������ ���� �ʽ��ϴ�. */
    [GetComponentInChild("Mesh")] public Transform _meshTransform;

    /* �ڽ� �� �θ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [GetComponentInParent]        public PlayerManager_Test _playerManager;


    /* ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� �迭 ���·� �����ɴϴ�. */
    [GetComponents]               public Component[] _components;

    /* ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [GetComponents]               public List<Component> _componentList;

    /* �ڽ� �� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� �迭 ���·� �����ɴϴ�. */
    [GetComponentsInChildren]     public CharacterWeapon_Test[] _childWeapons;

    /* �ڽ� �� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [GetComponentsInChildren]     public List<CharacterWeapon_Test> _childWeaponList;

    /* �ڽ� �� �θ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� �迭 ���·� �����ɴϴ�. */
    [GetComponentsInParent]       public Component[] _parentComponents;

    /* �ڽ� �� �θ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ���� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [GetComponentsInParent]       public List<Component> _parentComponentList;


    /* �ڽ��� ������ �ڽ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [GetComponentInChildrenOnly]  public Collider _childOnlyCollider;

    /* �ڽ��� ������ �θ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [GetComponentInParentOnly]    public Transform _parentOnlyTransform;

    /* �ڽ��� ������ �ڽ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ��� ã�� �迭 ���·� �����ɴϴ�. */
    [GetComponentsInChildrenOnly] public Collider[] _childOnlyColliders;

    /* �ڽ��� ������ �ڽ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ��� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [GetComponentsInChildrenOnly] public List<Collider> _childOnlyColliderList;

    /* �ڽ��� ������ �θ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ��� ã�� �迭 ���·� �����ɴϴ�. */
    [GetComponentsInParentOnly]   public Component[] _parentOnlyComponents;

    /* �ڽ��� ������ �θ� ���� ������Ʈ�鿡�� �ش� Ÿ���� ������Ʈ�� ��� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [GetComponentsInParentOnly]   public List<Component> _parentOnlyComponentList;


    /* ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� ������Ʈ�� �������� ���� ���, ������Ʈ�� ���Ӱ� ������ �� �����ɴϴ�. */
    [GetOrAddComponent]                    public Rigidbody _rigidbody;

    /* ������ �̸��� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� ������Ʈ�� �������� ���� ���, �ڽ� ���� ������Ʈ�� ������Ʈ�� ���Ӱ� ������ �� �����ɴϴ�.
       ���� �ش� �̸��� �ڽ� ���ӿ�����Ʈ�� �������� ���� ���, ������ �̸����� �ڽ� ���ӿ�����Ʈ�� �����մϴ�. */
    [GetOrAddComponentInChild("Pet")]     public PetController_Test _pet;

    /* �ڽ� �� �ڽ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� ������Ʈ�� �������� ���� ���, �ڽ� ���� ������Ʈ�� ������Ʈ�� ���Ӱ� ������ �� �����ɴϴ�.
       ���� �ش� �̸��� �ڽ� ���ӿ�����Ʈ�� �������� ���� ���, ������ �̸����� �ڽ� ���ӿ�����Ʈ�� �����մϴ�. */
    [GetOrAddComponentInChildren("Armor")] public CharacterArmor_Test _armor;

    /* �ڽ� �� �θ� ���� ������Ʈ ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� ������Ʈ�� �������� ���� ���, �ش� �θ� ���� ������Ʈ�� ������Ʈ�� ���Ӱ� ������ �� �����ɴϴ�.
       ���� �ش� �̸��� �θ� ���ӿ�����Ʈ�� �������� ���� ���, �ƹ��� ������ ���� �ʽ��ϴ�. */
    [GetOrAddComponentInParent("Player")]  public PlayerData_Test _playerData;


    /* ���� �� ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�. */
    [Find]                    public GameManager_Test _gameManager;

    /* ���� �� ������ �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� Ÿ���� ������Ʈ�� �ϳ��� �������� ���� ���, 
       ������ �̸����� ���� ������Ʈ�� ������ �� ������Ʈ �߰�*/
    [FindOrAdd("UI Manager")] public UIManager_Test _uiManager;

    /* ���� �� ������ ������ �̸��� ���� ������Ʈ�� ã��, �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� �̸��� ���� ������Ʈ�� �������� �ʰų� �ش� ������Ʈ�� �������� �ʴ� ���,
       �ƹ��� ������ ���� �ʽ��ϴ�. */
    [FindByName("Spawner")]   public Spawner_Test _spawner;

    /* ���� �� ������ ������ �̸��� ���� ������Ʈ�� ã��, �ش� Ÿ���� ������Ʈ�� ã�� �����ɴϴ�.
       ���� �ش� �̸��� ���� ������Ʈ�� �������� �ʰų� �ش� ������Ʈ�� �������� �ʴ� ���,
       �ش� �̸����� ���ο� ���� ������Ʈ�� ������ ��, ������Ʈ�� �߰��մϴ�. */
    [FindByNameOrAdd("Pool")] public ObjectPool_Test _objPool;

    /* ���� �� ������ �ش� Ÿ���� ������Ʈ�� ��� ã�� �迭 ���·� �����ɴϴ�. */
    [FindAll] public Transform[] _allTransforms;

    /* ���� �� ������ �ش� Ÿ���� ������Ʈ�� ��� ã�� ����Ʈ ���·� �����ɴϴ�. */
    [FindAll] public List<Collider> _allColliderList;
}
