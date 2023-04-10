import express from 'express';

const app = express();

app.get('/api/hello', (req, res) => {
    res.send('Hello world');
});

app.listen(3000, () => {
    console.log('Example app listening on port 3000!');
});