import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {


  addBoard(newBoard) {
    return http.post('/boards', newBoard)
  },

  getBoards() {
    return http.get('/boards');
  },

  getCards(boardID) {
    return http.get(`/boards/${boardID}`)
  },

  getCard(cardID) {
    return http.get(`/cards/${cardID}`)
  },

  addCard(card) {
    return http.post('/cards', card);
  },

  updateCard(card) {
    return http.put(`/cards/${card.id}`, card);
  },

  deleteCard(cardID) {
    return http.delete(`/cards/${cardID}`);
  }

}
