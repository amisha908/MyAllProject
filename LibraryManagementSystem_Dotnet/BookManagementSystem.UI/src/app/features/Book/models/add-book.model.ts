export interface AddBook{
    name: string;
    description: string;
    featuredImageUrl: string;
    urlHandle: string;
    author: string;
    isAvailable: boolean;
    genres: string[];
    // rating: number;
}