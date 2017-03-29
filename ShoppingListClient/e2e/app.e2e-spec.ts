import { ShoppingListClientPage } from './app.po';

describe('shopping-list-client App', function() {
  let page: ShoppingListClientPage;

  beforeEach(() => {
    page = new ShoppingListClientPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
