import { TestBed } from '@angular/core/testing';

import { UserReviewServiceService } from './user-review-service.service';

describe('UserReviewServiceService', () => {
  let service: UserReviewServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UserReviewServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
