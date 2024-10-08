﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using UrphaCapital.Application.Abstractions;
using UrphaCapital.Application.UseCases.Homework.Queries;
using UrphaCapital.Domain.Entities;

namespace UrphaCapital.Application.UseCases.Homework.QueriesHandler
{
    public class GetAllHomeworksByMentorIdQueryHandler : IRequestHandler<GetAllHomeworksByMentorIdQuery, IEnumerable<Homeworks>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllHomeworksByMentorIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Homeworks>> Handle(GetAllHomeworksByMentorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Homeworks
                .Include(x => x.Lesson)
                    .ThenInclude(x => x.Course)
                        .Where(x => x.Lesson.Course.MentorId == request.MentorId)
                            .Skip(request.Index - 1)
                                .Take(request.Count)
                            .Select(selector => new Homeworks()
                            {
                                Id = selector.Id,
                                LessonId = selector.LessonId,
                                Description = selector.Description,
                                Title = selector.Title,
                                FILE = selector.FILE,
                            })
                                .ToListAsync(cancellationToken);
        }
    }
}
