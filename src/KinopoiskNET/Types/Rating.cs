namespace Kinopoisk.Types;

public class Rating
{
    public float? Kinopoisk { get; set; }

    public float? Imdb { get; set; }

    public float? Tmdb { get; set; }

    /// <summary>
    /// Рейтинг кинокритиков
    /// </summary>
    public float? FilmCritics { get; set; }

    /// <summary>
    /// Рейтинг кинокритиков из РФ
    /// </summary>
    public float? RussianFilmCritics { get; set; }

    /// <summary>
    /// Рейтинг основанный на ожиданиях пользователей
    /// </summary>
    public float? Await { get; set; }

}