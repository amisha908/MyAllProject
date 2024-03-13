import { Genre } from "../../Genres/models/genre.model";

export interface Book{
    id: string;
    name: string;
    description: string;
    featuredImageUrl: string;
    urlHandle: string;
    author: string;
    isAvailable: boolean;
    genres: Genre[];
    lentByUserId: string;
    currentlyBorrowedByUserId: string;
}