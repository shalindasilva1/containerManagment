import { MaerskTemplatePage } from './app.po';

describe('Maersk App', function() {
  let page: MaerskTemplatePage;

  beforeEach(() => {
    page = new MaerskTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
