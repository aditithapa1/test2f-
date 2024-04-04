// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from Aditi"

type genreofmovies =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport




type Director = {
    Name : string
    Movies : int
}



type Movie = {
    Name : string
    RunLength : int
    genreofmovies : genreofmovies
    Director : Director
    IMDBRating : float
}


let changelength runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

// Create movie instances
let coda = { Name = "CODA"; RunLength = 111; genreofmovies = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
let belfast = { Name = "Belfast"; RunLength = 98; genreofmovies = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
let dontLookUp = { Name = "Don't Look Up"; RunLength = 138; genreofmovies = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
let driveMyCar = { Name = "Drive My Car"; RunLength = 179; genreofmovies = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
let dune = { Name = "Dune"; RunLength = 155; genreofmovies = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
let kingRichard = { Name = "King Richard"; RunLength = 144; genreofmovies = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
let licoricePizza = { Name = "Licorice Pizza"; RunLength = 133; genreofmovies = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
let nightmareAlley = { Name = "Nightmare Alley"; RunLength = 150; genreofmovies = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }

// Create a list of movies
let movies = [ coda; belfast; dontLookUp; driveMyCar; dune; kingRichard; licoricePizza; nightmareAlley ]

// Identify probable Oscar winners
let expectedwinner = List.filter (fun movie -> movie.IMDBRating > 7.4) movies

// Convert movie run length to hours
let newchangedlengths = List.map (fun movie -> (movie.Name, changelength movie.RunLength)) movies

// Print probable Oscar winners
printfn "Expected Oscar Winners:"
expectedwinner |> List.iter (fun movie -> printfn "- %s directed by %s" movie.Name movie.Director.Name)

// Print converted run lengths
printfn "\nConverted Run Lengths:"
newchangedlengths |> List.iter (fun (name, newchangedlength) -> printfn "- %s: %s" name newchangedlength)

