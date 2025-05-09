using UnityEngine;
using UnityEngine.UI;

public class feigh : MonoBehaviour
{
    public Image targetImage; // Ссылка на компонент Image
    public Sprite[] sprites = new Sprite[5]; // Массив из 5 спрайтов (для значений 1-5)

    [SerializeField]
    private int _variableValue = 1; //  Приватное поле для хранения значения
    public int variableValue
    {
        get { return _variableValue; }
        set
        {
            // Ограничиваем значение диапазона 1-5
            _variableValue = Mathf.Clamp(value, 1, 5);
            UpdateImage(); // Обновляем изображение при изменении значения
        }
    }

    void Start()
    {
        // Проверки на ошибки
        if (targetImage == null)
        {
            Debug.LogError("Target Image is not assigned!");
            enabled = false;
            return;
        }

        if (sprites == null || sprites.Length != 5)
        {
            Debug.LogError("Sprites array must have a size of 5!");
            enabled = false;
            return;
        }

        // Инициализация изображения при старте
        UpdateImage();
    }

    private void UpdateImage()
    {
        // Преобразуем значение переменной в индекс массива (1->0, 2->1 и т.д.)
        int spriteIndex = variableValue - 1;

        // Проверяем, что индекс в пределах массива
        if (spriteIndex >= 0 && spriteIndex < sprites.Length)
        {
            targetImage.sprite = sprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Sprite index out of range. This should not happen if the value is clamped between 1 and 5.");
        }
    }

    // Пример использования из другого скрипта
    public void SetVariableValue(int newValue)
    {
        variableValue = newValue;
    }
}