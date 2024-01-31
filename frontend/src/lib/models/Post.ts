export class Post {
    word: string;
    definitionDE: string;
    definitionEN: string;
    example: string;
    author: string;
    timestamp: string;

    constructor(word: string, 
        definitionDE: string,
        definitionEN: string,
        example: string,
        author: string,
        timestamp: string) {
            this.word = word;
            this.definitionDE = definitionDE;
            this.definitionEN = definitionEN;
            this.example = example;
            this.author = author;
            this.timestamp = timestamp;
    }
}

